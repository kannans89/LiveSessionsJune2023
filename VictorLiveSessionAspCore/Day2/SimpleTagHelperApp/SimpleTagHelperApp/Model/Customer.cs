using System.ComponentModel.DataAnnotations;

namespace SimpleTagHelperApp.Model
{
	public class Customer
	{
		[Display( Name = "First Name")]
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";
	}
}
