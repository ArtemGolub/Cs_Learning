using System.Diagnostics;

class Program
{
    static void Main()
    {
        TestMethod();
    }

    [Conditional("DEBUG")]
    static void TestMethod()
    {
        Console.WriteLine("Этот код выполняется только в режиме DEBUG.");
    }
}