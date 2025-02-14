using System.Collections;

namespace ConsoleLearning.Enumerations;

public class CustomEnumerator: IEnumerator<int>
{
    private readonly int[] _collection;
    private int _position = -1;
    public CustomEnumerator(int[] collection)
    {
        _collection = collection;
    }

    public bool MoveNext()
    {
        return ++_position < _collection.Length;
    }

    public void Reset()
    {
        _position = -1;
    }

    public int Current => _collection[_position];

    object? IEnumerator.Current => Current;

    public void Dispose()
    {
        // Освобождение ресурсов (если необходимо)
    }
}