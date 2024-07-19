using System;
using dotNetMenuProject.Context;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMenuProject.ViewComponents
{
	public class _CarouselViewComponentPartial : ViewComponent
	{
		MenuContext context = new MenuContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Carousels.ToList();
			return View(values);
		}
	}
}

