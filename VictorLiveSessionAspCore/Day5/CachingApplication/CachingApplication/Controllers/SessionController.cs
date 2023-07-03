using Microsoft.AspNetCore.Mvc;

namespace CachingApplication.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("counter") == null) {
                HttpContext.Session.SetInt32("counter", 0);
            }

            HttpContext.Session.SetInt32("counter",
            ((int)HttpContext.Session.GetInt32("counter")) + 1);

            return View();
        }
    }
}
