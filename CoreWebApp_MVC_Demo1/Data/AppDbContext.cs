using CoreWebApp_MVC_Demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApp_MVC_Demo1.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SVLH4LJ; Initial Catalog=DemoDB;User Id=SA; password=SA@123;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=true");
        }
    }
}
