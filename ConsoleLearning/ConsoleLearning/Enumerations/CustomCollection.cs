using System.Collections;

namespace ConsoleLearning.Enumerations;

public class CustomCollection: IEnumerable<int>
{
    private int[] items = {1, 2, 3, 4, 5};
    
    public IEnumerator<int> GetEnumerator()
    {
        return new CustomEnumerator(items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}