
using Microsoft.EntityFrameworkCore;
using slnEFCoreDatabaseFirst_StoreProcedure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnEFCoreDatabaseFirst_StoreProcedure.Data
{
    internal class LearningDBDataContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-SVLH4LJ; Initial Catalog=LearningDB;User Id=SA; password=SA@123;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=true");
        }
    }
}
