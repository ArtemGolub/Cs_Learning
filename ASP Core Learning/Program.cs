using ASP_Core_Learning.EFCore;

using NutShellContext dbContext = new NutShellContext();

var query = dbContext.Customers
    .Select(c => new
    {
        c.Name,
        c.Purchases
    });

foreach (var row in query)
    foreach (Purchase p in row.Purchases)
        Console.WriteLine($"{row.Name} spent {p.Price}");