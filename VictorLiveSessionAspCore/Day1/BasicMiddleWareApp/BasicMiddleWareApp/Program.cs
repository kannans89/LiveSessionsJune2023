using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

//services
var app = builder.Build();


//middlware

app.Use(async (context,nextMiddleWare) => {

    Console.WriteLine("Use1 Middleware before(R) "+context.Request.Path);
    await nextMiddleWare();
    Console.WriteLine("Use1 Middleware after(B) ");

});
app.Use(async (context, nextMiddleWare) =>
{

    Console.WriteLine("Use2 Middleware before(R) ");
    await nextMiddleWare();
    Console.WriteLine("Use2 Middleware after(B) ");

});

app.Map("/howdy", (appBuilder) =>
{

    appBuilder.Run(async (context) =>
    {
        await context.Response.WriteAsync("<h1>Howdy called</h1>");
    });
});

app.Run(async (context) => {

    await context.Response.WriteAsync("<h1>Run1</h1>");
});

app.Run(async (context) => {

    await context.Response.WriteAsync("<h1>Run2</h1>");
});


app.MapGet("/", () =>
{
    Console.WriteLine("Inside Map");
    return "Hello World!";
} );
app.Run();
