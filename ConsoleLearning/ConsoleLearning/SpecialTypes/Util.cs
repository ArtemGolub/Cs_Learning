namespace ConsoleLearning.SpecialTypes;

public delegate int Transformer(int arg);


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