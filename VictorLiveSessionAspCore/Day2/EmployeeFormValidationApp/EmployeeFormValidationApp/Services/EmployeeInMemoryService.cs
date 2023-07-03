using EmployeeFormValidationApp.Model;

namespace EmployeeFormValidationApp.Services
{
	public class EmployeeInMemoryService : IEmployeeService
	{
		private List<Employee> _employees;
		public EmployeeInMemoryService()
		{

			Console.WriteLine("EmpInmmeoryy service created");
			_employees = new List<Employee>();
			_employees.Add(new Employee
			{
				Id = 1,
				Name = "Kannan",
				IsActive = true
			});
			_employees.Add(new Employee
			{
				Id = 2,
				Name = "Victor",
				IsActive = true
			});
		}

		public List<Employee> GetEmployees()
		{
			return _employees;
		}
		public int HeadCount()
		{
			return _employees.Count;
		}

		public void Add(Employee employee)
		{
			_employees.Add(employee);
		}
	}
}
