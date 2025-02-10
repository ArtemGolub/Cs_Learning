using System.Collections;

namespace ConsoleLearning.Interfaces;

public class Countdown: IEnumerator
{
    private int count = 11;
    public bool MoveNext() => count-- > 0;
    public object? Current => count;
    
    public void Reset() =>
        throw new NotSupportedException();
}