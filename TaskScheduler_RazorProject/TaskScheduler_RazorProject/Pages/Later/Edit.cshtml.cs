using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskScheduler_RazorProject.Model;

namespace TaskScheduler_RazorProject.Pages.LaterList
{
    public class EditModel : PageModel
    {
        private Model.ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Model.Task Task { get; set; }

        public async System.Threading.Tasks.Task OnGet(int id)
        {
            Task = await _db.Task.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var TaskFromDb = await _db.Task.FindAsync(Task.Id);
                TaskFromDb.Title = Task.Title;
                TaskFromDb.Description = Task.Description;
                TaskFromDb.DueDate = Task.DueDate;
                TaskFromDb.DueTime = Task.DueTime;
                TaskFromDb.Color = Task.Color;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }
        }

    }
}
