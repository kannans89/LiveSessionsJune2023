using EmployeeFormValidationApp.DataValidators;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EmployeeFormValidationApp.ViewModel
{
	public class EmployeeAddVM
	{
        [Display(Name="employee id")]
        [Required(ErrorMessage ="Id is mandatory")]
        [Range(1,int.MaxValue)]
        public int Id { get; set; }


        [AllLetters(ErrorMessage ="Only nos allowed")]
        [Display(Name = "employee name")]
        [Required(ErrorMessage = "Name is mandatory")]
        [MaxLength(15, ErrorMessage = "max length is ony 15")]
        public string Name { get; set; } = "";

        public bool IsActive { get; set; }

        public string AddTitle { get; set; } = "";

        public string AddHeading { get; set; } = "";
    }
}
