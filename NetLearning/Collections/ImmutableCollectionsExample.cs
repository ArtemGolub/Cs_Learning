using System.Collections.Frozen;

namespace NetLearning.Collections;

public class ImmutableCollectionsExample
{
    public void Test()
    {
        int[] numbers = {1, 2, 3};
        FrozenSet<int> frozen = numbers.ToFrozenSet();
        
        FrozenSet<int> frozenSet;
        
        Console.WriteLine(frozen.Contains(2));
        
    }
}