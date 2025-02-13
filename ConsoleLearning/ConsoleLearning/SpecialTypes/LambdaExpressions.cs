namespace ConsoleLearning.SpecialTypes;

public class LambdaExpressions
{
    delegate int Transformer(int i);

    Func<string> greeter = () => "Hello";

    private Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
    private int total => totalLength("hello", "World");
}