﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using dotNetMenuProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetMenuProject.Controllers
{
    public class ApiController : Controller
    {
        SocialMediaModelFolowers socialMediaModelFolowers = new SocialMediaModelFolowers();
        SocialMediaFolowingModel socialMediaFolowingModel = new SocialMediaFolowingModel();
        WeatherViewModel weatherViewModel = new WeatherViewModel();
        CurrencyExchangeRate currencyRate = new CurrencyExchangeRate();

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            //weatherViewModel = await WeatherApi();
            socialMediaModelFolowers = await SocialMediaFolowerApi();
            socialMediaFolowingModel = await SocialMediaFolowingApi();
            currencyRate = await CurrencyRateApi("USD");
            ViewBag.USD = currencyRate.Data[0].Buying;
            currencyRate = await CurrencyRateApi("EUR");
            ViewBag.EUR = currencyRate.Data[0].Buying;
            //ViewBag.Temp = weatherViewModel.data.temp;
            ViewBag.Temp = "10";
            ViewBag.Folowers = socialMediaModelFolowers.Data.Total;
            ViewBag.Folowing = socialMediaFolowingModel.Data.Total;
            ViewBag.Post = 0;
            

            
                    
            return View();
        }


    //    public async Task<WeatherViewModel> WeatherApi()
    //    {
    //        //Weather APi Start
    //        var client = new HttpClient();
    //        var request = new HttpRequestMessage
    //        {
    //            Method = HttpMethod.Get,
    //            RequestUri = new Uri("https://the-weather-api.p.rapidapi.com/api/weather/bolu"),
    //            Headers =
    //{
    //    { "x-rapidapi-key", "a54022c22cmsh8d30dd428c56503p1a8657jsn345def8d4313" },
    //    { "x-rapidapi-host", "the-weather-api.p.rapidapi.com" },
    //},
    //        };
    //        using (var response = await client.SendAsync(request))
    //        {
    //            response.EnsureSuccessStatusCode();
    //            var body = await response.Content.ReadAsStringAsync();
    //            var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);
    //            return values;
    //        }
    //        //Weather APi End

    //    }

        public async Task<SocialMediaModelFolowers> SocialMediaFolowerApi()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-scraper-api2.p.rapidapi.com/v1/followers?username_or_id_or_url=enes.aks29"),
                Headers =
                {
                    { "x-rapidapi-key", "9a04a18fddmsh86deec957be4437p16f6edjsn38057fff1011" },
                    { "x-rapidapi-host", "instagram-scraper-api2.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<SocialMediaModelFolowers>(body);
                return values;
            }
        }

        public async Task<SocialMediaFolowingModel> SocialMediaFolowingApi()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-scraper-api2.p.rapidapi.com/v1/following?username_or_id_or_url=enes.aks29"),
                Headers =
                {
                    { "x-rapidapi-key", "9a04a18fddmsh86deec957be4437p16f6edjsn38057fff1011" },
                    { "x-rapidapi-host", "instagram-scraper-api2.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<SocialMediaFolowingModel>(body);
                return values;
            }
        }

        public async Task<CurrencyExchangeRate> CurrencyRateApi(string code)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://doviz-ve-altin-fiyatlari-try.p.rapidapi.com/economy/currency/exchange-rate?code={code}"),
                Headers =
    {
        { "x-rapidapi-key", "a54022c22cmsh8d30dd428c56503p1a8657jsn345def8d4313" },
        { "x-rapidapi-host", "doviz-ve-altin-fiyatlari-try.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<CurrencyExchangeRate>(body); // Single object
                return value;
            }
        }





    }
}

