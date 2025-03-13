using System.Linq.Expressions;

namespace ASP_Core_Learning.EFCore;

public class Product
{
    public int ID { get; set; }
    public string Description { get; set; }
    public bool Discontinued { get; set; }
    public DateTime LastSale { get; set; }


    public static Expression<Func<Product, bool>> IsSelling() =>
        p => !p.Discontinued && p.LastSale > DateTime.Now.AddDays(-30);
    
}