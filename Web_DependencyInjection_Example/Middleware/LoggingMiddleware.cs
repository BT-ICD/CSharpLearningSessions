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
            await _next(context);
        }
    }
    public static class UseLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddlware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}
