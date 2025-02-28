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
            from n1 in
            (
                from n in names
                select n.Replace("a", "").Replace("e", "").Replace("i", "")
            )
            where n1.Length > 2
            orderby n1
            select n1;
    }
    
}