using EFCoreConsoleApplication.Data;


namespace EFCoreConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new OrganizationDbContext();
            db.Organizations.Add(new Organization 
            { Name="Microsfot",Description="Microsoft" });
            db.SaveChanges();
            Console.WriteLine("end");
        }
    }
}