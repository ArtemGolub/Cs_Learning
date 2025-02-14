namespace ConsoleLearning.Enumerations;

public class FibbonachyIterator
{
    public IEnumerable<int> Fibs(int fibCount)
    {
        for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++)
        {
            yield return prevFib;
            int newFib = prevFib + curFib;
            prevFib = curFib;
            curFib = newFib;
        }
    }

    public IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
    {
        foreach (int x in sequence)
        {
            if ((x % 2) == 0) // можно делить на 2 без остатка
                yield return x;
        }
    }
}