using SimpleWebApiApp.Data;

namespace SimpleWebApiApp.Repository
{
    public class OrganizationRepository : IOrganizationRepository
    {

        private readonly OrganizationDbContext _db;

        public OrganizationRepository(OrganizationDbContext db)
        {
            _db = db;
        }

        public List<Organization> GetOrganizations()
        {

            return _db.Organizations.ToList();
        }

        public void AddOrganization(Organization organisation)
        {
            _db.Organizations.Add(organisation);
            _db.SaveChanges();
        }

        public void UpdateOrganization(int organizaitonId, Organization newOrg) {

           
            var org = _db.Organizations.Single(o => o.Id == organizaitonId);
            org.Name = newOrg.Name;
            org.EmployeeCount = newOrg.EmployeeCount;

            _db.SaveChanges();
        }

        public void Remove(int organizaitonId)
        {


            var org = _db.Organizations.Single(o => o.Id == organizaitonId);
            _db.Organizations.Remove(org);

            _db.SaveChanges();
        }


    }
}
