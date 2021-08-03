using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaskScheduler_RazorProject.Model;

namespace TaskScheduler_RazorProject.Pages
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
    }
}
