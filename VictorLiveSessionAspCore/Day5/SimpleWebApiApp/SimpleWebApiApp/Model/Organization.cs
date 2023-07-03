using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApiApp.Data
{
    public class Organization
    {
        public int Id { get; set; }

        [Display(Name = "organisation name")]
        public string Name { get; set; }

        [Display(Name = "organisation emp coutn")]
        public int EmployeeCount { get; set; }

       
        public override string ToString()
        {
            return Id+","+Name+","+EmployeeCount;
        }
    }

}
