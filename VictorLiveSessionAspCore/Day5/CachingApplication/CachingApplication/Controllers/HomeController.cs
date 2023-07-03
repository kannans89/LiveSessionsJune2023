using CachingApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace CachingApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _memoryCache;
        public HomeController(ILogger<HomeController> logger,IMemoryCache memmroyCache)
        {
            _logger = logger;
            _memoryCache = memmroyCache;
        }

        public IActionResult Index(int deptno=0)
        {
            ViewBag.deptno = deptno;
            return View();
        }

        public IActionResult Privacy()
        {
            string time = null;
            if (!_memoryCache.TryGetValue("time", out time)) {

                time = DateTime.Now.ToLocalTime().ToString();
                _memoryCache.Set("time", time, 
                    
                 new MemoryCacheEntryOptions()
                {

                    AbsoluteExpirationRelativeToNow = (DateTime.Now.AddSeconds(5) - DateTime.Now)
                });
            }

            ViewBag.time = time;

            return View();
        }

        [ResponseCache(Duration =5)]
        public IActionResult Test() {
            string time = DateTime.Now.ToLocalTime().ToString();
            return Content($"<h1>time is {time}</h1>","text/html");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}