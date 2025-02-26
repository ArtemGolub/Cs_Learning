namespace NetLearning;

public class Program
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        IEnumerable<string> filtedNames = names
            .Where(n => n.Contains("a"))
            .OrderBy(n => n.Length)
            .Select(n => n.ToUpper());

        IEnumerable<string> filtedNames2 =
            from n in names
            where n.Contains("a")
            orderby n.Length
            select n.ToUpper();

        foreach (string name in filtedNames)
            Console.WriteLine(name);
    }
    
}