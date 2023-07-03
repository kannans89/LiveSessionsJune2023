using SimpleWebApiApp.Data;

namespace SimpleWebApiApp.Repository
{
    public interface IOrganizationRepository
    {
        void AddOrganization(Organization organisation);
        List<Organization> GetOrganizations();

        void UpdateOrganization(int organizaitonId, Organization newOrg);
        void Remove(int organizaitonId);
    }
}