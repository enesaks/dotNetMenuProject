    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using dotNetMenuProject.Context;
    using dotNetMenuProject.Entities;

    namespace dotNetMenuProject.Controllers
    {
        public class DefaultController : Controller
        {
            MenuContext context = new MenuContext();

            // GET: /<controller>/
            public IActionResult Index()
            {
                ViewBag.p1 = "250 yıllık sırlarla dolu özel odamıza hoşgeldiniz. Burası AcunMedya bir odaya sığan kocaman dostluklar, kutlamalar, özel anlaşmalar ve davetleri için Olden tutkunlarına açıldı. Eski bir hikayede yeni uzun sofralar kurmak için rezervasyon yaptırmanız yeterli.\n";
                ViewBag.p2 = "Geçmişin değerlerini içselleştirip onları bugünle buluşturarak geleceğe taşıyan tohumları atmayı hedefleyen Lacivert, menüsünü bu anlayışla hazırlıyor. Menümüzün klasikleşen lezzetlerine, yeni ve çarpıcı dokunuşlar da ekleyerek mevsimselliği ve yerelin güzelliklerini yansıtan bir çerçeve içinde hareket ediyoruz, daha bilinçli bir tüketimi hedefliyoruz.";

                return View();
            }

            public PartialViewResult PartialHead()
            {
                return PartialView();
            }
            public PartialViewResult PartialNavbar()
            {
                return PartialView();
            }
            
            public PartialViewResult PartialFeature()
            {
                return PartialView();
            }
            public PartialViewResult PartialTeam()
            {
                //var values = context.Chefs.Where(x => x.Status == true).ToList();
                return PartialView();
            }
            public PartialViewResult PartialTestimonial()
            {
                return PartialView();
            }

            [HttpGet]
            public PartialViewResult PartialContact()
            {
                return PartialView();
            }
            [HttpPost]
            public IActionResult PartialContact(Message message)
            {
                context.Messages.Add(message);
                context.SaveChanges();
                TempData["Message"] = "Mesajınız gönderildi!";
                return RedirectToAction("Index");
            }

            public PartialViewResult PartialFooter()
            {
                return PartialView();
            }
            [HttpPost]
            public IActionResult PartialFooter(Journal journal)
            {
                context.Journals.Add(journal);
                context.SaveChanges();
                TempData["journal"] = "Bültene Kaydınız Alındı";
                return RedirectToAction("Index");
            
            }

        public PartialViewResult PartialScript()
            {
                return PartialView();
            }
            [HttpGet]
            public PartialViewResult CreateBooking()
            {
            
                return PartialView();
            }

            [HttpPost]
            public IActionResult CreateBooking(Booking booking)
            {
                booking.BookingDate = DateTime.SpecifyKind(booking.BookingDate, DateTimeKind.Utc);
                booking.Description = "Rezervasyon Alındı";
                context.Bookings.Add(booking);
                context.SaveChanges();
                TempData["Rezervasyon"] = "Rezervasyon başarıyla oluşturuldu!";
                return RedirectToAction("Index");
            }

    }
    }

