using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthencitaionViaCookieApp.ViewModels
{
    public class LoginVM
    {
      
        [Required(ErrorMessage ="UserId must be entered by user")]
        [DataType(DataType.Text)]
        public string UserId { get; set; }

        [Required(ErrorMessage ="UserPassword must be entered by user")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}