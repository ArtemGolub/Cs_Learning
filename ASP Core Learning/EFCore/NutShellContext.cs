﻿using Microsoft.EntityFrameworkCore;

namespace ASP_Core_Learning.EFCore;

public class NutShellContext: DbContext
{
    public DbSet<Customer> Customers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer", "dbo");
            entity.Property(e => e.Name)
                .HasColumnName("Full Name")
                .IsRequired();
        });
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=localhost;Database=customerLearningDb;Trusted_Connection=True;TrustServerCertificate=True")
            .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information); // Логирование запросов
    }

}