using Microsoft.EntityFrameworkCore;

namespace ASP_Core_Learning.EFCore;

public class NutShellContext: DbContext
{
    public DbSet<Customer> Customers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");
            entity.Property(e => e.Name)
                .HasColumnName("Full Name")
                .IsRequired();
        });
}