using System;
using Microsoft.AspNetCore.Mvc;
using dotNetMenuProject.Context;

namespace dotNetMenuProject.ViewComponents.DashboardViewComponents
{
	public class _StatisticsViewComponentPartial : ViewComponent
	{
		MenuContext context = new MenuContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.productCount = context.Products.Count();
			ViewBag.activeProductCount = context.Products.Where(x => x.Status == true).Count();
			ViewBag.avgProductCount = context.Products.Average(x => x.Price);

			Random rnd = new Random();
			int count = rnd.Next(10, 31);

			ViewBag.bookingCount = count;
			return View();
		}
	}
}

