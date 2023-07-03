using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSqlConsoleApp.Data
{
    public class OrganizationDbContext:DbContext
    {
        public DbSet<Organization> Organizations { get; set; }

        public OrganizationDbContext
            (DbContextOptions<OrganizationDbContext> options)
           : base(options)

        {

        }
    }
}
