namespace ASP_Core_Learning.EFCore;

public class Customer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}