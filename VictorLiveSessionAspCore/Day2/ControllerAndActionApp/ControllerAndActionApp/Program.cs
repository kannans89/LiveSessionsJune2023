using ControllerAndActionApp.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IDataService,DataService>();
var app = builder.Build();


app.UseStaticFiles();
//app.MapDefaultControllerRoute();

app.MapControllerRoute(name:"default",
    pattern:"{controller}/{action}/{id?}",
    defaults:new { controller ="Home",action= "Index" });
app.Run();
