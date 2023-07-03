using EFCoreMVCApplication.Repository;
using EFCoreSqlConsoleApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreMVCApplication.Controllers
{
    public class HomeController : Controller
    {

        IOrganizationRepository _repo;
        public HomeController(IOrganizationRepository repo) { 
        
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display() { 
        
             return View(_repo.GetOrganizations());
        }

        public IActionResult Add() {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Organization org)
        {

            _repo.AddOrganization(org);
            return RedirectToAction("Display");
        }
    }
}
