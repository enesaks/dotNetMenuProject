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
    public class JournalController : Controller
    {
        MenuContext context = new MenuContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(context.Journals.ToList());
        }

        [HttpGet]
        public IActionResult JournalDelete(int id)
        {
            var values = context.Journals.Find(id);
            context.Journals.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

