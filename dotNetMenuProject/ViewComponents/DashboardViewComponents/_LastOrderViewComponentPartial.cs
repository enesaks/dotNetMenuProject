using System;
using dotNetMenuProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMenuProject.ViewComponents.DashboardViewComponents
{
	public class _LastOrderViewComponentPartial : ViewComponent
	{
		MenuContext context = new MenuContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Orders.ToList();
			return View(values);
		}
	}
}

