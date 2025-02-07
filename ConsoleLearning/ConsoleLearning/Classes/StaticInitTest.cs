namespace ConsoleLearning.Classes;

public class StaticInitTest
{
    static StaticInitTest()
    {
        Console.WriteLine("StaticInitTest");
    }

    ~StaticInitTest()
    {
        Console.WriteLine("~Finalizer");
    }
}