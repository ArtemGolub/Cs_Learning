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



        IEnumerable<string> query =
            from n in names
            select n.Replace("a", "").Replace("e", "").Replace("i", "");
        
        query = 
            from n in query
            where n.Length > 2
            orderby n
            select n;
    }
    
}