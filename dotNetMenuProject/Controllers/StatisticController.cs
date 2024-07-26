using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetMenuProject.Context;
using dotNetMenuProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMenuProject.Controllers
{
    public class StatisticController : Controller
    {
        MenuContext context = new MenuContext();
        public IActionResult Index()
        {
            ViewBag.productCount = context.Products.Count();
            ViewBag.activeProductCount = context.Products.Where(x => x.Status == true).Count();
            ViewBag.avgProductCount = context.Products.Average(x => x.Price);
            ViewBag.bookingCount = context.Bookings.Count(); 
            ViewBag.messageCount = context.Messages.Count();
            ViewBag.activeChefCount = context.Chefs.Where(x => x.Status == true).Count();
            ViewBag.ChefCount = context.Chefs.Count();
            ViewBag.journalCount = context.Journals.Count();
            ViewBag.orderCount = context.Orders.Count();
            ViewBag.SliderCount = context.Carousels.Count();
            ViewBag.confrimOrderCount = context.Orders.Where(x=>x.OrderStatus == "İşlem Onaylandı").Count();
            ViewBag.waitOrderCount = context.Orders.Where(x=>x.OrderStatus == "İşlem Bekleniyor").Count();
            ViewBag.cencelOrderCount = context.Orders.Where(x=>x.OrderStatus == "İşlem İptal Edildi").Count();



            //#TODO
            return View();
        }
    }
}

