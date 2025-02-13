namespace ConsoleLearning.SpecialTypes;

public class LambdaExpressions
{
    delegate int Transformer(int i);

    Func<string> greeter = () => "Hello";

    private Func<string, string, int> totalLength = (s1, s2) => s1.Length + s2.Length;
    private int total => totalLength("hello", "World");


    void Foo<T>(T x) { }
    void Bar<T>(Action<T> a) { }




    
    
    public void MyMethod()
    {
        Func<int, int> multiplier = static n => n * 2;
        static int Multiply(int x) => x * 2;
    }
}