namespace NetLearning;

public class Program
{
    public static void Main()
    {
        string[] names =
        {
            "Dabid Gilmour",
            "Roger Waters",
            "Rick Wright",
            "Nick Mason"
        };

        var filtred = names.Where(n => n.Contains("a"));
        var sorted = filtred.OrderBy(n => n);
        var query = sorted.Select(n => n.ToUpper());
    }
    
}