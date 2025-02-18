namespace ConsoleLearning.Variables;

ref struct Point
{
    public readonly int X, Y;

    public Point(int x, int y) => (X, Y) = (x, y);

}