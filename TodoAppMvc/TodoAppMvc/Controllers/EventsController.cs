using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TodoAppMvc.Models;

// Our events controller all the CRUD actions of our web app
// Since our app displays events by separate days, we must pass information 
//  on which day user wants to access.

namespace TodoAppMvc.Controllers
{
    public class EventsController : Controller
    {
        private readonly MvcEventsContext _context;

        public EventsController(MvcEventsContext context)
        {
            _context = context;
        }

        // GET: Events
        public async Task<IActionResult> Index(string day = null)
        {
            //  First we get all events in our database and sort them by due date and time.
            IQueryable<Event> events = from e in _context.Event
                                       orderby e.DateTime ascending, e.DueDate descending
                                       select e;

            //  Our program only lists events due today or later. 
            //  Therefore if there are events past the date of today,
            //  A function is called to delete the events from database
            if (events.Any())
            { 
                if (events.Last().DueDate < DateTime.Today.Date)
                {
                    DeleteOverDueEvents();
                }
            }

            String stringDayFormat = "";
            
            //  The events are filtered to only be of the due date for a specific page view. 
            if (!String.IsNullOrEmpty(day))
            {
                if (day.Equals("0"))
                {
                    events = events.Where(s => s.DueDate == DateTime.Today.Date);
                    stringDayFormat = DateTime.Today.Date.ToString("dddd, MMMM dd");
                }
                else if (day.Equals("1"))
                {
                    events = events.Where(s => s.DueDate == DateTime.Today.AddDays(1).Date);
                    stringDayFormat = DateTime.Today.AddDays(1).ToString("dddd, MMMM dd");
                }
                else if(day.Equals("2"))
                {
                    events = events.Where(s => s.DueDate == DateTime.Today.AddDays(2).Date);
                    stringDayFormat = DateTime.Today.AddDays(2).ToString("dddd, MMMM dd");
                }
                else if (day.Equals("3"))
                {
                    events = events.Where(s => s.DueDate == DateTime.Today.AddDays(3).Date);
                    stringDayFormat = DateTime.Today.AddDays(3).ToString("dddd, MMMM dd");
                }
                else if (day.Equals("4"))
                {
                    events = events.Where(s => s.DueDate == DateTime.Today.AddDays(4).Date);
                    stringDayFormat = DateTime.Today.AddDays(4).ToString("dddd, MMMM dd");
                }
                else if (day.Equals("5"))
                {
                    events = events.Where(s => s.DueDate == DateTime.Today.AddDays(5).Date);
                    stringDayFormat = DateTime.Today.AddDays(5).ToString("dddd, MMMM dd");
                }
                else if (day.Equals("6"))
                {
                    events = events.Where(s => s.DueDate == DateTime.Today.AddDays(6).Date);
                    stringDayFormat = DateTime.Today.AddDays(6).ToString("dddd, MMMM dd");
                }
            }
            else
            {
                // if error return home page
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            ViewData["DayTitle"] = stringDayFormat;
            ViewData["Day"] = day;

            return View(await events.ToListAsync());
        }

        //  Delete events past the current date 
        private async void DeleteOverDueEvents()
        {
            _context.RemoveRange(_context.Event.Where(e => e.DueDate < DateTime.Today.Date));
            await _context.SaveChangesAsync();
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id, string day = "0")
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            ViewData["Day"] = day;

            return View(@event);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,DueDate,DateTime,Color")] Event @event, string day="0")
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { day });
            }
            return View(@event);
        }

        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(int? id,  string day="0")
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            ViewData["Day"] = day;

            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Title,Description,DueDate,DateTime,Color")] Event @event, string day = "0")
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", new { day });
            }
            return View(@event);
        }

        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(int? id, string day = "0")
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            ViewData["Day"] = day;

            return View(@event);
        }

        // POST: Events/Delete/5?day
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, string day = "0")
        {
            var @event = await _context.Event.FindAsync(id);
            _context.Event.Remove(@event);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { day });
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.Id == id);
        }
    }
}
