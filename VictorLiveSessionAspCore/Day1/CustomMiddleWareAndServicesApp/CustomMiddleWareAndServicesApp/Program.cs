using CustomMiddleWareAndServicesApp.MiddleWares;
using CustomMiddleWareAndServicesApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IEmailService,SendGridEmailService>();
//builder.Services.AddScoped<IEmailService, SendGridEmailService>();
//builder.Services.AddTransient<IEmailService, SendGridEmailService>();
builder.Services.AddControllersWithViews();

var app = builder.Build();



string x="Victor";
Console.WriteLine(x.Hello());

//app.UseMiddleware(typeof(FooMiddlWare));
//app.UseMiddleware<FooMiddlWare>();

app.UseMyFooMiddlWare();

app.UseStaticFiles();

app.MapDefaultControllerRoute();//{controller=Home}/{action=Index}/{id?}

///app.MapGet("/", () => "Hello World!");

app.Run();
