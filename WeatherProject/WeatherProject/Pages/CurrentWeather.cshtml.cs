using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WeatherProject.Pages
{
    public class WeatherData
    {
        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; }
        public string Base {get; set;}
        public Main Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public long Dt { get; set; }
        public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }

    public class CurrentWeatherModel : PageModel
    {
        HttpClient client = new HttpClient();

        [BindProperty]
        public string City { get; set; }

        [BindProperty]
        public float Temperature { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public string Image { get; set; }


        public async Task<IActionResult> OnGet()
        {
            City = Request.Query["city"];

            var api_key = "ff48f5a6e091ffa34cc6440d41c3da7e";
            var unit = "imperial";
            var url = "https://api.openweathermap.org/data/2.5/weather?q=" + City + "&appid=" + api_key + "&units=" + unit;

            
            //  Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );

            //  Json File for openweathermap.ord is all lowercase
            //  We assign case insesitivity to handle lower case names
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var response = client.GetStringAsync(url);

            //  If City input exist, we read the json file and convert to object
            //  else we handle 404 (Not Found) error and redirect to an error page.
            try
            {
                var msg = await response;

                WeatherData weather = JsonSerializer.Deserialize<WeatherData>(msg, options);

                Temperature = weather.Main.Temp;
                Description = weather.Weather[0].Description;

                Image = weather.Weather[0].Icon.Substring(0, 2);
            }
            catch (Exception)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }

    public class Coord
    {
        public float Lon { get; set; }
        public float Lat { get; set; }
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
        public float Feels_like { get; set; }
        public float Temp_min { get; set; }
        public float Temp_max { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
    }

    public class Wind
    {
        public float Speed { get; set; }
        public float Deg { get; set; }
        public float Gust { get; set; }
    }

    public class Clouds
    {
        public int All { get; set; }
    }

    public class Sys
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }
}