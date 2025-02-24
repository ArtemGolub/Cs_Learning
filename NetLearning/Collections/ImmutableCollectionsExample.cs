using System.Collections.Immutable;

namespace NetLearning.Collections;

public class ImmutableCollectionsExample
{
    public void Test()
    {
        ImmutableList<int> oldList = ImmutableList.Create<int>(1, 2, 3);
        ImmutableList<int> newList = oldList.AddRange([4,5,6]);
        
        Console.WriteLine(oldList.Count);
        Console.WriteLine(newList.Count);
    }
}