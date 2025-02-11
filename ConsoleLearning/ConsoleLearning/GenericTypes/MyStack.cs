namespace ConsoleLearning.GenericTypes;

public class MyStack<T>
{
    public static T GetDefaultValue()
    {
        Console.WriteLine($"{default(T)}");
        return default(T);
    }
}