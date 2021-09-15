using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoAppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcEventsContext _context;

        public HomeController(MvcEventsContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View( _context.Event.Count());
        }
    }
}
