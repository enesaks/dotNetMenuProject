using System;
using dotNetMenuProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMenuProject.ViewComponents
{
	public class _AboutComponentPartial : ViewComponent
	{
		MenuContext context = new MenuContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Abouts.ToList();
			return View(values);
		}
	}
}

