using System;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMenuProject.ViewComponents.DashboardViewComponents
{
	public class _SidebarViewComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

