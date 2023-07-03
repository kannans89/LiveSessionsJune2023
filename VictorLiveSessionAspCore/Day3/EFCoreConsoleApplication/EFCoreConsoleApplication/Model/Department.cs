using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConsoleApplication
{
    public class Department
    {

        public Department() {

            Employees = new List<Employee>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }    

        public virtual ICollection<Employee> Employees { get; set; }=new List<Employee>();

    }
}
