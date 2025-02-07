namespace ConsoleLearning.Classes;

public partial class PaymentForm
{
    private readonly int _a;
    public PaymentForm(int a)
    {
    }

    public void Method1()
    {
        Console.WriteLine("Method1");
    }
}

public partial class PaymentForm
{
    private readonly string _b;

    public PaymentForm(string b)
    {
        _b = b;
    }

    public void Method2()
    {
        Console.WriteLine("Method2");
    }
}