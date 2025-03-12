using ASP_Core_Learning.EFCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using NutShellContext dbContext = new NutShellContext();

var saraCustomer = dbContext.Customers
    .Where(c => c.Name == "Sara");
foreach (Customer customer in saraCustomer)
{
    customer.Name = "Sara Conor";
}
dbContext.SaveChanges();


foreach (var e in dbContext.ChangeTracker.Entries())
{
    Console.WriteLine($"{e.Entity.GetType().FullName} is {e.State}");
    foreach (MemberEntry member in e.Members)
        Console.WriteLine($"{member.Metadata.Name}: '{member.CurrentValue}' modified: {member.IsModified}");
}

