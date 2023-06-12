using System;
using System.Collections.Generic;
using EFCoreScaffoldDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreScaffoldDatabase.Data;

public partial class LearningDbContext : DbContext
{
    public LearningDbContext()
    {
    }

    public LearningDbContext(DbContextOptions<LearningDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-SVLH4LJ; Initial Catalog=LearningDB;User Id=SA; password=SA@123;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
