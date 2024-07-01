using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
namespace dotNetMenuProject.Controllers
{
    public class WeatherController : Controller
    {
       
        public async Task<IActionResult> Index()
        {
            /*
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weather-api-by-any-city.p.rapidapi.com/weather/Ankara"),
                Headers =
                {
                    { "x-rapidapi-key", "9d15b0d74bmshf87a4ae058b2695p1c746bjsnfb94aa854e8f" },
                    { "x-rapidapi-host", "weather-api-by-any-city.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
            */
            return View();
            
        }
    }
}

