namespace ConsoleLearning.TryCatch;

public class TryCtachPractice
{
    public void MyMethod()
    {
        try
        {
            int y = Calc(0);
            Console.WriteLine(y);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("x cannot be zero");
            throw;
        }
        Console.WriteLine("Done");
    }
    int Calc(int x) => 10 / x;
}