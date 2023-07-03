using Microsoft.AspNetCore.Mvc;

namespace EmployeeFormValidationApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
