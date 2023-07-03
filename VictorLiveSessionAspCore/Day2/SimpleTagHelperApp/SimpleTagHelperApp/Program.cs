var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


app.UseStaticFiles();
app.MapControllerRoute(name: "default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Home", action = "IndexV4" });

app.Run();
