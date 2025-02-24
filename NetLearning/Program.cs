using NetLearning.EqualityComparers;

namespace NetLearning;

public class Program
{
    public static void Main()
    {
        Customer c1 = new("Bloggs", "Joe");
        Customer c2 = new("Bloggs", "Joe");
        
        LastFirstEqComparer eqComparer = new();
        
        Dictionary<Customer, string> customers = new(eqComparer);
        customers[c1] = "Joe";
        Console.Write(customers.ContainsKey(c2)); // true
    }
}