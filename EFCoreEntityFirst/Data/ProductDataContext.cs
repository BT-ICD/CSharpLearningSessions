using EFCoreEntityFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreEntityFirst.Data
{
    internal class ProductDataContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SVLH4LJ; Initial Catalog=LearningDB;User Id=SA; password=SA@123;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=true");
            //base.OnConfiguring(optionsBuilder);
        }

    }
}
