namespace ConsoleLearning.Stack_Heap;

public class FactorialOperation
{
    static int Factorial(int x)
    {
        if (x == 0) return 1;
        return x * Factorial(x - 1);
    }
}