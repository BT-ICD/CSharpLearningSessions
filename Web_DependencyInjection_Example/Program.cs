using Microsoft.EntityFrameworkCore;
using Web_DependencyInjection_Example.Data;
using Web_DependencyInjection_Example.Implementations;
using Web_DependencyInjection_Example.Interfaces;
using Web_DependencyInjection_Example.Services;

var builder = WebApplication.CreateBuilder(args);

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
//builder.Services.AddScoped<IMessageWriter, FileMessageWriter>();
builder.Services.AddSingleton<CarRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
