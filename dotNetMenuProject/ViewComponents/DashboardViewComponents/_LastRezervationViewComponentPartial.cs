using System;
using Microsoft.AspNetCore.Mvc;
using dotNetMenuProject.Context;

namespace dotNetMenuProject.ViewComponents.DashboardViewComponents
{
	public class _LastRezervationViewComponentPartial : ViewComponent
	{
		MenuContext context = new MenuContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Bookings.ToList().TakeLast(6).ToList();
			return View(values);
		}
	}
}

