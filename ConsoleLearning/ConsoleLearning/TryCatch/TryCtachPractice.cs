using System.Net;

namespace ConsoleLearning.TryCatch;

public class TryCtachPractice
{
    public void MyMethod()
    {
        Display(null);
    }
    
    void Display(string name)
    {
        ArgumentNullException.ThrowIfNull(name);
        Console.WriteLine(name);
    }

}