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
        Action[] actions333 = new Action[3];
        Action[] actions123 = new Action[3];
        
        for (int i = 0; i < 3; i++)
            actions333[i] = () => Console.WriteLine(i);

        for (int i = 0; i < 3; i++)
        {
            int loopScopedi = i; 
            actions123[i] = () => Console.WriteLine(loopScopedi);
        }
        
        foreach (Action action in actions333)
            action();
        
        foreach (Action action in actions123)
            action();
    }
}