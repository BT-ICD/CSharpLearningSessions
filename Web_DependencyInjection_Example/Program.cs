using Microsoft.EntityFrameworkCore;
using Web_DependencyInjection_Example.Data;
using Web_DependencyInjection_Example.Helper;
using Web_DependencyInjection_Example.Implementations;
using Web_DependencyInjection_Example.Interfaces;
using Web_DependencyInjection_Example.Middleware;
using Web_DependencyInjection_Example.Services;
using NLog;
using NLog.Web;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");

try
{
    var builder = WebApplication.CreateBuilder(args);


    // NLog: Setup NLog for Dependency injection
    builder.Logging.ClearProviders();
    //builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
    builder.Host.UseNLog();

    //To implement Auto Mapper
    builder.Services.AddAutoMapper(typeof(Program));

    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();


    string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

    //Depenency Injection for the Message Service - FileMessageWriter
    builder.Services.AddScoped<IMessageWriter, ConsoleMessageWriter>();
    //builder.Services.AddScoped<IProduct, ProductRepository_Mock>();
    builder.Services.AddScoped<IProduct, ProductRepositoryDb>();
    builder.Services.AddScoped<IMessageWriter, FileMessageWriter>();
    builder.Services.AddSingleton<CarRepository>();
    //builder.Services.AddSingleton<LoggingMiddleware>();

    //Position as dependency injection - service container
    builder.Services.Configure<PositionOptions>(builder.Configuration.GetSection(PositionOptions.Position));

    //To implement token based authentication
    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
            //options =>
            //{
            //    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            //    {
            //        ValidIssuer = "SoftwareOrg",
            //        ValidAudience= "WebApp",
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("AAAAAAAAAAAAAAAAAAA"))
            //    };
            //}    
            options => options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidIssuer = "SoftwareOrg",
                ValidAudience = "WebApp",
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("AAAAAAAAAAAAAAAAAAA"))

            }
        );

    //

   

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseMiddleware<LoggingMiddleware>();
    //To implement authentication - JWT 
    app.UseAuthentication();
    app.UseAuthorization();

    //app.UseLoggerMiddlewareExtension();
    //app.UseRequestCulture();

    //Add Custom Middleware without using custom Extension Method
    //app.UseMiddleware<LoggingMiddleware>();
    //Add Custom Middleware using custom extension method
    //app.UseLoggingMiddlware();
    app.MapControllers();

    app.Run();


}
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
    
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}