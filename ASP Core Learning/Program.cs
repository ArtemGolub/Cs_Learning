using ASP_Core_Learning.EFCore;

using var dbContext = new NutShellContext();


var cust = new Customer()
{
    Name = "Sara Wells"
};
dbContext.Add(cust);
dbContext.SaveChanges();

var customer = dbContext.Customers
    .FirstOrDefault(x => x.Name == "Sara Wells");

if (customer != null)
{
    Console.WriteLine($"Added {customer.Name}");
}
else
{
    Console.WriteLine("Customer not found.");
}