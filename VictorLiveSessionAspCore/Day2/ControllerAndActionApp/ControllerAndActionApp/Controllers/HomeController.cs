using Microsoft.AspNetCore.Mvc;

namespace ControllerAndActionApp.Controllers
{

	
	public class HomeController : Controller
	{
		public string Index()
		{
			return  "hello";
		}

		
		public FileResult  ShowLogo() {

			return File("/logo.jpg", "image/jpeg");
		}

		public Object GetRandom() {

			
		    var random = new Random();
			var result = random.Next(1, 10);
			if(result>=5)
				 return ShowLogo();

			return  Content( Index());

        }

		public IActionResult RedirectV1() {

			return Redirect("http://www.gogole.com");
		}

		public IActionResult RedirectV2() { 
		 return RedirectToAction("Index");
		}

        public IActionResult RedirectV3()
        {
			return RedirectToAction("index", "customer");
        }

		[Route("[controller]/getImage",Name ="myImageRoute")]
		public IActionResult GetImage() {
            return File("/logo.jpg", "image/jpeg");
        }

        public IActionResult RedirectV4()
        {
			
			return RedirectToRoute("myImageRoute");
        }

		public IActionResult CheckEmail() {
            var random = new Random();
            var result = random.Next(1, 10);
            if (result >= 5)
             {
				return StatusCode(200);
			}
			return StatusCode(500);
		}
    }
}
