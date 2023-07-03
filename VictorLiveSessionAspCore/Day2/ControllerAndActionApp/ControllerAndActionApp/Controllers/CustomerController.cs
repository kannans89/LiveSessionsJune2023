using ControllerAndActionApp.Filters;

using ControllerAndActionApp.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControllerAndActionApp.Controllers
{
    [LogThisAction]
    public class CustomerController : Controller
	{

      
        public IActionResult Index(int id)
		{
			return Content("display id :"+id);
		}

		
		public IActionResult IndexV2(string name) {
            return Content("display name :" + name);
        }
		public IActionResult Detail() {

			var customer = new Customer();
			customer.Id = 101;
			customer.Name = "Victor";
			return View(customer);
		}
	}
}
