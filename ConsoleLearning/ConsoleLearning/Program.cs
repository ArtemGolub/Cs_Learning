using System.Runtime.CompilerServices;

public class Program
{
    static void Main()
    {
        int number = 5;
        LogExpression(number > 10);
        LogExpression(number == 5);
    }

    static void LogExpression(
        bool condition,
        [CallerArgumentExpression("condition")] string? expression = null)
    {
        Console.WriteLine($"Выражение: {expression}, результат: {condition}");
    }
}