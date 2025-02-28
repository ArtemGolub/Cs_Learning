namespace NetLearning;

public class Program
{
    public static void Main()
    {
        string[] musos =
        {
            "Dabid Gilmour",
            "Roger Waters",
            "Rick Wright",
            "Nick Mason"
        };

        IEnumerable<string> query = musos.OrderBy(m => m.Split().Last());
    }
    
}