using Microsoft.AspNetCore.Mvc;
using OrgClientApp.Models;
using System.Collections;
using System.Diagnostics;

namespace OrgClientApp.Controllers
{
    class OrganizationDTO { 
       public string Name { get; set; }
        public int EmployeeCount { get; set; }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHttpClientFactory _httpClientFactory;
        public HomeController(ILogger<HomeController> logger, IHttpClientFactory factory)
        {
            _logger = logger;
            _httpClientFactory = factory;
        }


        public async Task<IActionResult> GetOrganisations()
        {
            int orgCount = 0;
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:5259");

            var reponse = await httpClient.GetAsync("api/Organization");
            if (reponse.IsSuccessStatusCode)
            {
               var orgList= reponse.Content.ReadAsAsync<List<OrganizationDTO>>();
                orgCount = orgList.Result.Count;
            }

            return Content("get data "+orgCount);
        }

        public async Task<IActionResult> AddOrganistaion() {

            var testOrganiation = new OrganizationDTO { Name="test ogranisation2" ,EmployeeCount=10};
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:5259");
            var response= await httpClient.PostAsJsonAsync("api/Organization",testOrganiation);
            if (response.IsSuccessStatusCode) {
               return RedirectToAction("GetOrganisations");
            }
            return Content("something went wrong");
        }
        public IActionResult Index()
        {


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}