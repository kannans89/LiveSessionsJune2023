using EmployeeFormValidationApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IEmployeeService,EmployeeInMemoryService>();
var app = builder.Build();


app.UseStaticFiles();
app.MapControllerRoute(name: "default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Employee", action = "Index" });
app.Run();
