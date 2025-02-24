using NetLearning.EqualityComparers;

namespace NetLearning;

public class Program
{
    public static void Main()
    {

    }

    static bool Foo<T>(T x, T y)
    {
        bool same = EqualityComparer<T>.Default.Equals(x, y);
        return same;
    }
}