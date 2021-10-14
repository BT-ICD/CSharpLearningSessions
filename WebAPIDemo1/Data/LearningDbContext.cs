using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo1.Models;

namespace WebAPIDemo1.Data
{
    public class LearningDbContext : DbContext
    {
        public LearningDbContext(DbContextOptions<LearningDbContext> options): base(options)
        {

        }
        public DbSet<Dept> Depts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dept>().ToTable("Dept");
            base.OnModelCreating(modelBuilder);
        }
    }
}
