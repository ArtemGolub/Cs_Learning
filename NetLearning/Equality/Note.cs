namespace NetLearning.Equality;

public struct Note: IComparable<Note>, IComparable
{
    int _semitonesFromA;
    public Note(int semitonesFromA)
    {
        _semitonesFromA = semitonesFromA;
    }

    public int CompareTo(Note other)
    {
        if (Equals(other)) return 0;
        return _semitonesFromA.CompareTo(other._semitonesFromA);
    }
    
    int IComparable.CompareTo(object? other)
    {
        if (!(other is Note))
            throw new InvalidOperationException();

        return CompareTo((Note)other);
    }

    public static bool operator <(Note n1, Note n2) 
        => n1.CompareTo(n2) < 0;

    public static bool operator >(Note n1, Note n2)
        => n1.CompareTo(n2) > 0;
}