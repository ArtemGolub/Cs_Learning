namespace ConsoleLearning.SpecialTypes;

public delegate string Logger(string arg);

public class MyLogger
{
    public static void Log(Logger logger, string value)
    {
        Console.WriteLine(logger(value));
    }
}


public class Util
{
    public static void Transfrom<T>(T[] values, Func<T, T> transformer)
    {
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = transformer(values[i]);
        }
    }
}