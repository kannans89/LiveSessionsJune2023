using CustomMiddleWareAndServicesApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomMiddleWareAndServicesApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailService _emailService;
        public HomeController(IEmailService service) {
            _emailService = service;
            Console.WriteLine("HomeCtonroller created");
        }
        public async Task<IActionResult> Index()
        {
            await _emailService.SendEmail("index page of home contorlled");
            return Content("<h1>Index page of home contoller</h1>","text/html");
        }
    }
}
