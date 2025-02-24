namespace NetLearning;

public class Program
{
    public static void Main()
    {
        string[] names = { "Tom", "Dick", "Harry" };
        IEnumerable<string> filtedNames = names
            .Where(n => n.Length > 3);

        foreach (string name in filtedNames)
            Console.WriteLine(name);
    }
    
}