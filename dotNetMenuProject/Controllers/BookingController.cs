using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetMenuProject.Context;
using dotNetMenuProject.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotNetMenuProject.Controllers
{
    public class BookingController : Controller
    {
        MenuContext context = new MenuContext();
        public IActionResult Index()
        {
            var values = context.Bookings.ToList();
            return View(values);
        }



        public IActionResult BookingDelete(int id)
        {
            var values = context.Bookings.Find(id);
            context.Bookings.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}

