namespace ConsoleLearning.Interfaces;

public interface ILogger
{
    void Log(string text)
    {
        Console.WriteLine(text);
    }
}