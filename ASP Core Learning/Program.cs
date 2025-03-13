using ASP_Core_Learning.EFCore;

using NutShellContext dbContext = new NutShellContext();

Product[] localProducts = dbContext.Products.ToArray();
var sqlQuery = FilerSortProducts(dbContext.Products);
var localQuery = FilerSortProducts(localProducts.AsQueryable());

IQueryable<Product> FilerSortProducts(IQueryable<Product> input)
{
    return from p in input
            .Where(p => p.Discontinued)
            .OrderByDescending(p => p.Discontinued)
            select p;
}