
interface IAddable<T> where T : IAddable<T>
{
    abstract static T operator +(T a, T b);
}

record Point(int X, int Y) : IAddable<Point>
{
    public static Point operator +(Point left, Point right) 
        => new Point(left.X + right.X, left.Y + right.Y);
}


public class Program
{
    static T Sum<T>(params T[] values) where T : IAddable<T>
    {
        T total = values[0];
        for (int i = 1; i < values.Length; i++)
            total += values[i];
        
        return total;
    }
    public static void Main()
    {
        var p1 = new Point(1, 2);
        var p2 = new Point(3, 4);
        Point[] points = { p1, p2 };
        Console.WriteLine(Sum(points));
    }
}
