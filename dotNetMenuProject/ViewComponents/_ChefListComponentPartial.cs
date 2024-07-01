using System;
using Microsoft.AspNetCore.Mvc;
using dotNetMenuProject.Context;
namespace dotNetMenuProject.ViewComponents
{
	public class _ChefListComponentPartial : ViewComponent
	{
		MenuContext context = new MenuContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Chefs.Where(x => x.Status == true).ToList();
			return View(values);
		}
	}
}

