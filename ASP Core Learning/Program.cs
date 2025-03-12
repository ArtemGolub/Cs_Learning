using ASP_Core_Learning.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using NutShellContext dbContext = new NutShellContext();

var custInfo = dbContext.Customers
    .Where(c => c.ID == 15)
    .Select(c => new
    {
        Name = c.Name,
        Purchases = c.Purchases
            .Select(p => new
            {
                p.Description,
                p.Price
            })
    })
    .First();

foreach (var DP in custInfo.Purchases)
{
    Console.WriteLine($"{custInfo.Name} bought: {DP.Description} with price: {DP.Price}");
}




