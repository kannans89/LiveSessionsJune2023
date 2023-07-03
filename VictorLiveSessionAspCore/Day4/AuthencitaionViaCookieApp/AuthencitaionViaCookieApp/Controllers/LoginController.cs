using AuthencitaionViaCookieApp.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AuthencitaionViaCookieApp.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			LoginVM vm = new LoginVM();
			vm.UserId = "test";
			return View(vm);
		}

		[HttpPost]
        public async Task<IActionResult> Index(LoginVM vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            //After proper check with database

            var claims = new List<Claim> {
             new Claim(ClaimTypes.Name,vm.UserId)
            };
            var identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

           // TempData["user"] = vm.UserId;
            return RedirectToAction("Index", "Home");
           
        }

        public async  Task<IActionResult> SignOut() {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
