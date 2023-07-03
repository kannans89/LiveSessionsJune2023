using EFCoreSqlConsoleApp.Data;

namespace EFCoreMVCApplication.Repository
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

    }
}
