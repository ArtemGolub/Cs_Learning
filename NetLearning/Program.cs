using NetLearning.LINQ;

namespace NetLearning;

public class Program
{
    public static void Main()
    {
        string[] names =
        {
            "Tom",
            "Dick",
            "Harry",
            "Mary",
            "Jay"
        };
        
        IEnumerable<string> query =
            from n in names
            let vowelless = n.Replace("a", "").Replace("e", "")
                .Replace("i", "").Replace("o", "").Replace("u", "")
            where vowelless.Length > 2
            orderby vowelless
            select n;
    }
    
}