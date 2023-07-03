using Microsoft.AspNetCore.Mvc;
using SimpleTagHelperApp.Model;

namespace SimpleTagHelperApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult IndexV2() {
			return View();
		}

		public IActionResult IndexV3() {
			var c = new Customer { 
			 FirstName= "Victor",
			 LastName = "Do"
			};
			return View(c);
		}
		public IActionResult IndexV4()
		{
			return View();
		}
	}
}
