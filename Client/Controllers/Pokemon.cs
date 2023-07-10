using Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Client.Controllers
{
	public class Pokemon : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
