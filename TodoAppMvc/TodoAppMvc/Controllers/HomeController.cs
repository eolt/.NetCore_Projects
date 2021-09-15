using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Our home page solely lists the number of events our database. 
//  So our controller returns the count of our database using the db context.

namespace TodoAppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcEventsContext _context;
        
        //  configure dependency injection to access db context 
        public HomeController(MvcEventsContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {   
            //  use the count() method to get number of events
            //  return events to the view home page
            return View( _context.Event.Count());
        }
    }
}
