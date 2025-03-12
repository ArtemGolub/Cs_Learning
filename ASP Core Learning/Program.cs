using ASP_Core_Learning.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using NutShellContext dbContext = new NutShellContext();

List<Customer> cust = dbContext.Customers
    .Include(c => c.Purchases)
    .Where(c => c.Purchases.Count >= 2)
    .ToList();

foreach (Customer customer in cust)
{
    Console.WriteLine($"{customer.Name} with {customer.Purchases.Count} purchases");
}


