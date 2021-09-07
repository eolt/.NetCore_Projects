using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WeatherProject.Pages
{
    public class NotFoundModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public string CityName { get; set; }

        public IActionResult OnPost()
        {
            return Redirect("/CurrentWeather?city=" + CityName);
        }
    }
}
