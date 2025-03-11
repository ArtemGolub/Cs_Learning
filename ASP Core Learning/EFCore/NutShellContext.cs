using Microsoft.EntityFrameworkCore;

namespace ASP_Core_Learning.EFCore;

public class NutShellContext: DbContext
{
    public DbSet<Customer> Customers { get; set; }
}