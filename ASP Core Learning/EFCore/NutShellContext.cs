using Microsoft.EntityFrameworkCore;

namespace ASP_Core_Learning.EFCore;

public class NutShellContext: DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");
            entity.Property(e => e.Name)
                .HasColumnName("Full Name")
                .IsRequired();
        });

}