using System;
using Microsoft.AspNetCore.Mvc;
namespace dotNetMenuProject.ViewComponents.DashboardViewComponents
{
	public class _GetLocationViewComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

