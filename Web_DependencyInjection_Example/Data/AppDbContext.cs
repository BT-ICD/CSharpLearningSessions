using Microsoft.EntityFrameworkCore;
using Web_DependencyInjection_Example.Models;

namespace Web_DependencyInjection_Example.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
