namespace NetLearning.Equality;

public struct Area: IEquatable<Area>
{
    public readonly int Measure1;
    public readonly int Measure2;
    
    public Area(int m1, int m2)
    {
        Measure1 = Math.Min(m1, m2);
        Measure2 = Math.Max(m1, m2);
    }

    public override bool Equals(object? other) 
        => other is Area a && Equals(a);
    public bool Equals(Area other) 
        => Measure1 == other.Measure1 && Measure2 == other.Measure2;

    public override int GetHashCode()
        => HashCode.Combine(Measure1, Measure2);

    public static bool operator ==(Area a1, Area a2) => Equals(a1, a2);
    public static bool operator !=(Area a1, Area a2) => !(a1 == a2);
}