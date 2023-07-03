using Microsoft.AspNetCore.Mvc;

namespace RazorPageFormApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return Content("<h1>This MVC from a razor app</h1>","text/html");
		}
	}
}
