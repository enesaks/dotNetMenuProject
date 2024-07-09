﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using dotNetMenuProject.Models;

namespace dotNetMenuProject.Controllers
{
    public class WeatherController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetWeather(WeatherViewModel.Data model)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://the-weather-api.p.rapidapi.com/api/weather/{model.City}"),
                Headers =
                {
                    { "x-rapidapi-key", "9d15b0d74bmshf87a4ae058b2695p1c746bjsnfb94aa854e8f" },
                    { "x-rapidapi-host", "the-weather-api.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);
                return View("WeatherResult", values.data);
            }
        }
    }
}
