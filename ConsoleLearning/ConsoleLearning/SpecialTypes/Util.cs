namespace ConsoleLearning.SpecialTypes;

public delegate T Transformer<T>(T arg);


public class Util
{
    public static void Transfrom<T>(T[] values, Transformer<T> transformer)
    {
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = transformer(values[i]);
        }
    }
}