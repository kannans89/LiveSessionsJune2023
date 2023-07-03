using EFCoreSqlConsoleApp.Data;

namespace EFCoreMVCApplication.Repository
{
    public interface IOrganizationRepository
    {
        void AddOrganization(Organization organisation);
        List<Organization> GetOrganizations();
    }
}