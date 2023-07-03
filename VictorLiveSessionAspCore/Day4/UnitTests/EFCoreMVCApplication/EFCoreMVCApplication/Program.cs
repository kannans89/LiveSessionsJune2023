using EFCoreMVCApplication.Repository;
using EFCoreSqlConsoleApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<OrganizationDbContext>(options =>
           options.UseSqlServer(
               builder.Configuration.
               GetConnectionString("prodDbServer"))
               );

builder.Services.AddScoped<IOrganizationRepository,OrganizationRepository>();
var app = builder.Build();


app.UseStaticFiles();
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=About}/{action=Index}/{id?}");

app.Run();
