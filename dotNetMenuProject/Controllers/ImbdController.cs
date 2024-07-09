using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using dotNetMenuProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetMenuProject.Controllers
{
    public class ImbdController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "9d15b0d74bmshf87a4ae058b2695p1c746bjsnfb94aa854e8f" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ImbdViewModel>>(body);
                return View(values.ToList());
            }
           
        }

        public async Task<IActionResult> SeriesList()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/series/"),
                Headers =
    {
        { "x-rapidapi-key", "9d15b0d74bmshf87a4ae058b2695p1c746bjsnfb94aa854e8f" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ImbdSeriesViewModel>>(body);
                return View(values.ToList());
            }
        }
    }
}

