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
    public class MessageController : Controller
    {
        MenuContext context = new MenuContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

       

        [HttpGet]
        public IActionResult MessageDelete(int id)
        {
            var values = context.Messages.Find(id);
            context.Messages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var values = context.Messages.Find(id);

            return View(values);
        }
        


    }
}

