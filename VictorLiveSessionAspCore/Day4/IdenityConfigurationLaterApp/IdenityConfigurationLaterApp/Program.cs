using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using IdenityConfigurationLaterApp.Data;
using IdenityConfigurationLaterApp.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IdenityConfigurationLaterAppContextConnection") ?? throw new InvalidOperationException("Connection string 'IdenityConfigurationLaterAppContextConnection' not found.");

builder.Services.AddDbContext<IdenityConfigurationLaterAppContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdenityConfigurationLaterAppUser>
    (options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdenityConfigurationLaterAppContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
