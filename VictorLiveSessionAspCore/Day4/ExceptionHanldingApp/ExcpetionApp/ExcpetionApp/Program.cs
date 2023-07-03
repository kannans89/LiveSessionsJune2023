var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var config = builder.Configuration.GetSection("Logging");
//Console.WriteLine(config.Key);

builder.Logging.ClearProviders();
builder.Logging.AddConfiguration(config);
builder.Logging.AddConsole();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseExceptionHandler("/Home/Error");
}
else 
    app.UseDeveloperExceptionPage();


app.UseStatusCodePages( async (builder) => {

   await builder.HttpContext.Response.WriteAsync("status code page "+builder.HttpContext.Response.StatusCode);
});

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
