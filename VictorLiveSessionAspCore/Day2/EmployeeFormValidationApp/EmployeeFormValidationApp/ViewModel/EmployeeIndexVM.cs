using EmployeeFormValidationApp.Model;

namespace EmployeeFormValidationApp.ViewModel
{
    public class EmployeeIndexVM
    {
        public string IndexPageTile { get; set; } = "";
        public string IndexPageHeading { get; set; } = "";
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public int EmployeeCount { get; set; }

        public string GetEmpStatus(bool status) {
            return status == true ? "Active" : "InActive";
        }
    }
}
