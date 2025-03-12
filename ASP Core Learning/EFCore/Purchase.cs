namespace ASP_Core_Learning.EFCore;

public class Purchase
{
    public int ID { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public Decimal Price { get; set; }
    
    public int? CustomerID { get; set; }
    public virtual Customer Customer { get; set; }
}