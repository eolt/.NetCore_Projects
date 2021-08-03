using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskScheduler_RazorProject.Model;

namespace TaskScheduler_RazorProject.Pages.TomorrowList
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Model.Task> Tasks { get; set; }

        public async System.Threading.Tasks.Task OnGet()
        {
            Tasks = await _db.Task.ToListAsync();           
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var task = await _db.Task.FindAsync(id);
            if(task == null)
            {
                return NotFound();
            }

            _db.Task.Remove(task);
            await _db.SaveChangesAsync();
            return RedirectToPage("index");
        }
    }
}
