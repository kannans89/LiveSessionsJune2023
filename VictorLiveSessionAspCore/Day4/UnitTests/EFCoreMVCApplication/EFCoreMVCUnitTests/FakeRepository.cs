using EFCoreMVCApplication.Repository;
using EFCoreSqlConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMVCUnitTests
{
    internal class FakeRepository : IOrganizationRepository
    {
        private List<Organization> list = new List<Organization>() { 
         new Organization{Id=1}
        };
        public void AddOrganization(Organization organisation)
        {
            list.Add(organisation);
        }

        public List<Organization> GetOrganizations()
        {
            return list;
        }
    }
}
