using System;
using dotNetMenuProject.Context;
using Microsoft.AspNetCore.Mvc;
namespace dotNetMenuProject.ViewComponents
{
	public class _MenuListComponentPartial : ViewComponent
	{
		MenuContext context = new MenuContext();

		public IViewComponentResult Invoke()
		{
			var values = context.Products.ToList();
			return View(values);
		}
	}
}

