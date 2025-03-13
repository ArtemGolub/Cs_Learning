using ASP_Core_Learning.EFCore;

using NutShellContext dbContext = new NutShellContext();

Product[] localProducts = dbContext.Products.ToArray();

IQueryable<Product> sqlQuery = dbContext.Products
    .Where(Product.IsSelling());
    
IEnumerable<Product> localQuery = localProducts
    .Where(Product.IsSelling().Compile());