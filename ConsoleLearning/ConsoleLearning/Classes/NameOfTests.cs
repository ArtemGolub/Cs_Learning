using System.Text;

namespace ConsoleLearning.Classes;

public class NameOfTests
{
    string name = nameof(StringBuilder.Length);

    public void LogName()
    {
        Console.WriteLine($"{name}");
    }
}