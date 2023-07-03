using EmployeeFormValidationApp.Model;
using EmployeeFormValidationApp.Services;
using EmployeeFormValidationApp.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeFormValidationApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService emp)
        {

            _employeeService = emp;
        }
        public IActionResult Index()
        {
            EmployeeIndexVM vm = new EmployeeIndexVM();
            vm.IndexPageTile = "Index page";
            vm.IndexPageHeading = "Welcome to Index page";
            vm.Employees = _employeeService.GetEmployees();
            vm.EmployeeCount = _employeeService.HeadCount();

            return View(vm);
        }

        public IActionResult Add()
        {
            EmployeeAddVM vm = new EmployeeAddVM();
            vm.AddTitle = "Add emp";
            vm.AddHeading = "Add employee page";
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(EmployeeAddVM vm) {
            if (!ModelState.IsValid)
                return View(vm);

            _employeeService.Add(ConvertToEmp(vm));
            return RedirectToAction("Index");
        }

        private Employee ConvertToEmp(EmployeeAddVM vm)
        {
            return new Employee {
             Id = vm.Id,
             Name=vm.Name,
             IsActive=vm.IsActive
            };
        }
    }
}
