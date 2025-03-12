using ASP_Core_Learning.EFCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using NutShellContext dbContext = new NutShellContext();

Customer cust = dbContext.Customers.OrderBy(c => c.Name).First();

Console.WriteLine(cust.Name);

