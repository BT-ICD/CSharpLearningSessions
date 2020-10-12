using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Middleware_Demo_1.Middlewares
{
    public static class MyLoggerMiddlewareExtension
    {
        public static IApplicationBuilder UseMyLoggerMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyLoggerMiddleware>();
        }
    }
}
