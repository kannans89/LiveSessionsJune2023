﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConsoleApplication
{

    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; } = "";
        public virtual ICollection<Department> Departments { get; set; } =new List<Department>();



    }
}
