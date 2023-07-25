using Web_DependencyInjection_Example.Interfaces;

namespace Web_DependencyInjection_Example.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //messageWriter.WriteMessage($"Method - {context.Request.Method}, Path: {context.Request.Path}");
            Console.WriteLine($"Method - {context.Request.Method}, Path: {context.Request.Path}");
            
            var resut = context.Request.Headers.TryGetValue("x-name", out var hederData );
            if (resut)
            {
                Console.Write(hederData);
                Console.Write(hederData.ToString());
                if(hederData.ToString()=="Rajesh Shah")
                {
                    await _next(context);
                }
                else
                {
                    await context.Response.WriteAsync("Middlware Pipe Line Crashed...");
                }
            }
            else
            {
                await context.Response.WriteAsync("Middlware Pipe Line Crashed...");
            }
            

            
            //await _next(context);
        }
    }
    //Extension Method to add Middleware using method UseLoggingMiddlewareExtensions
    public static class UseLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddlware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}
