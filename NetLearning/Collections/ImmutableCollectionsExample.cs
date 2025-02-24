using System.Collections.Immutable;

namespace NetLearning.Collections;

public class ImmutableCollectionsExample
{
    public void Test()
    {
        ImmutableArray<int> myImmutable = ImmutableArray.Create(1, 2, 3);
        var builder2 = myImmutable.ToBuilder(); // переводим в билдер
        builder2.Add(4);  // эффективная операция
        builder2.Remove(2); // эффективная операция
        
        ImmutableArray<int> myImmutable2 = builder2.ToImmutable(); // возвращаем неизменяемую коллекцию
    }
}