using crudApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace crudApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		List<string> names = new List<string>();
		public IActionResult Index()
		{
			names.Add("Adel");
			names.Add("Turki");
			names.Add("Ahmed");

			if (names != null)
            {
				ViewData["names"] = names;
            }

			return View();
		}
		
		private int Add(int num1, int num2)
		{
			return num1 + num2;
		}
		
		public IActionResult Details(string? name)
		{
			if (names != null)
			{
				foreach (var n in names)
				{
					if (n == name)
					{
						ViewBag.name = n;
					}
				}
			}
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
