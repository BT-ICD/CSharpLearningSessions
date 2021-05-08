using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC1.Entities;

namespace WebApplicationMVC1.DataContext
{
    public class MyAppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Bhavin;Initial Catalog=LearningDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<DEPT> Depts{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DEPT>(builder =>
            {
                builder.HasNoKey();
                builder.ToTable("DEPT");
            });


        }
    }
}
