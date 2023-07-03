using CrossSiteScriptingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CrossSiteScriptingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SendComment2()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SendComment2(string comment)
        {

            ViewBag.Comment = comment;
            return View();
        }

       


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}