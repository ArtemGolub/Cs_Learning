namespace ConsoleLearning.Classes;

public class Calculator
{
    // Метод без параметров
    public int Add()
    {
        return 0; // Значение по умолчанию
    }

    public int Foo(int x)
    {
        return 0;
    }
    public int Foo(ref int x)
    {
        return 0;
    }

// Метод с двумя параметрами
    public int Add(int a, int b)
    {
        return a + b;
    }

// Метод с тремя параметрами
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    // Метод с разными типами аргументов
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Метод с разным порядком параметров
    public string Add(string a, string b)
    {
        return a + b;
    }
}