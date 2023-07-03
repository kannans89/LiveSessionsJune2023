using System.ComponentModel.DataAnnotations;

namespace EmployeeFormValidationApp.DataValidators
{
	public class AllLetters:ValidationAttribute
	{
		public override bool IsValid(object? value)
		{
			var inputName = value as string;
			if (inputName == null)
				return false;
			foreach (char c in inputName) {
				if (Char.IsNumber(c))
					return false;
			}

			return true;
		}
	}
}
