namespace ConsoleLearning.Variables;

public struct Point(int x, int y)
{
    public readonly int X = x, Y = y;
    
    public static Point operator +(Point a, Point b) => new(a.X + b.X, a.Y + b.Y);
    public override string ToString() => $"({X}, {Y})";
}