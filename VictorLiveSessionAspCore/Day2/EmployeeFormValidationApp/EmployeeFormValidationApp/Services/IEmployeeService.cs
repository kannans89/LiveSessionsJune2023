using EmployeeFormValidationApp.Model;

namespace EmployeeFormValidationApp.Services
{
	public interface IEmployeeService
	{
		void Add(Employee employee);
		List<Employee> GetEmployees();
		int HeadCount();
	}
}