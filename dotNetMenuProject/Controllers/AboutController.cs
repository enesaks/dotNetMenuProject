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
    public class AboutController : Controller
    {
        MenuContext context = new MenuContext();
        public IActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AboutCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AboutCreate(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AboutDelete(int id)
        {
            var values = context.Abouts.Find(id);
            context.Abouts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var values = context.Abouts.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

