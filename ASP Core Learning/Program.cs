using ASP_Core_Learning.EFCore;

using var dbContext = new NutShellContext();
Customer cust = new Customer()
{
    Name = "Sara Wells"
};
dbContext.Add(cust);
dbContext.SaveChanges();

Console.WriteLine($"Added {dbContext.Customers
    .Single(x => x.Name == "Sara Wells")}");