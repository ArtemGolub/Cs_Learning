using NetLearning.Collections;

namespace NetLearning;

public class Program
{
    public static void Main()
    {
        Test t = new Test();
        Console.WriteLine(t.Names.Count);
        t.AddInternally();
        Console.WriteLine(t.Names.Count);
    }
}