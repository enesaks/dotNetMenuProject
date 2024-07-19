using System;
using Microsoft.AspNetCore.Mvc;
using dotNetMenuProject.Context;

namespace dotNetMenuProject.ViewComponents
{
	public class _FoodListComponentPartial : ViewComponent
	{
		MenuContext context = new MenuContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Products.Where(x=> x.Status == true).ToList().TakeLast(3).ToList();
			return View(values);
		}
	}
}

