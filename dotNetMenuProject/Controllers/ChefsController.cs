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
    public class ChefsController : Controller
    {
        MenuContext context = new MenuContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = context.Chefs.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult ChefsCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChefsCreate(Chef chef)
        {
            context.Chefs.Add(chef);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ChefsDelete(int id)
        {
            var values = context.Chefs.Find(id);
            context.Chefs.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ChefsUpdate(int id)
        {
            var values = context.Chefs.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult ChefsUpdate(Chef chef)
        {
            context.Chefs.Update(chef);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

