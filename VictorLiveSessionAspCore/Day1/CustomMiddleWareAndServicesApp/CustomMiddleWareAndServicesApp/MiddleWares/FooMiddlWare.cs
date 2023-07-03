using CustomMiddleWareAndServicesApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleWareAndServicesApp.MiddleWares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class FooMiddlWare
    {
        private readonly RequestDelegate _next;

        public FooMiddlWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,IEmailService service)
        {
            Console.WriteLine("Before Foo");
            await service.SendEmail("emailing from Invoke method of foo");
            await _next(httpContext);
            Console.WriteLine("After foo");
        }
    }

    //// Extension method used to add the middleware to the HTTP request pipeline.
    public static class FooMiddlWareExtensions
    {
        public static IApplicationBuilder UseMyFooMiddlWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<FooMiddlWare>();
        }
    }
}
