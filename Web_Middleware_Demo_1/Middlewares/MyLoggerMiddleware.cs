using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Middleware_Demo_1.Middlewares
{
    public class MyLoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerFactory _loggerFactory;
        public MyLoggerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _loggerFactory = loggerFactory;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var logger = _loggerFactory.CreateLogger<MyLoggerMiddleware>();
            try
            {
                logger.LogInformation("Performing Middleware Operation - Entering Middleware ");
                logger.LogInformation("Context.Request.Host.Value " + context.Request.Host.Value);
                logger.LogInformation("Context.Request.Path.Value " + context.Request.Path.Value);
                
                // await context.Response.WriteAsync( "Short Circuit!");
                await _next(context);
                logger.LogInformation("Performing Middleware Operation - Exit Middleware ");
            }
            catch (Exception ex) 
            {
                logger.LogError($"Something went wrong: {ex.Message}");
            }
        }
    }
}
