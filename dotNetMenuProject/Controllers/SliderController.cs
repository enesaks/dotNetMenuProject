using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotNetMenuProject.Context;
using dotNetMenuProject.Entities;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetMenuProject.Controllers
{
    public class SliderController : Controller
    {
        MenuContext context = new MenuContext();
        public IActionResult Index()
        {
            var values = context.Carousels.ToList();
            return View(values);
        }


        [HttpGet]
        public IActionResult SliderCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SliderCreate(Carousel carousel)
        {
            context.Carousels.Add(carousel);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult SliderDelete(int id)
        {
            var values = context.Carousels.Find(id);
            context.Carousels.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult SliderUpdate(int id)
        {
            var values = context.Carousels.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult SliderUpdate(Carousel carousel)
        {
            context.Carousels.Update(carousel);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

