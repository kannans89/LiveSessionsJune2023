using EFCoreSqlConsoleApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreMVCApplication.Controllers
{
    public class AboutController : Controller
    {
        private OrganizationDbContext _db;
        public AboutController(OrganizationDbContext db) {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.OrgisationCount = _db.Organizations.Count();
            return View();
        }
    }
}
