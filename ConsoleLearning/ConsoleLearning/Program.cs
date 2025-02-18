interface ICreateRandom<T>
{
    static abstract T CreateRandom();
}

record Point(int X, int Y) : ICreateRandom<Point>
{
     static Random _rnd = new ();
     public static Point CreateRandom() => new ( _rnd.Next(), _rnd.Next());
     


}

public class Program
{

    static T[] CreateTestData<T> (int count) where T: ICreateRandom<T>
    {
        T[] data = new T[count];
        for (int i = 0; i < count; i++)
            data[i] = T.CreateRandom();
    
        return data;
    }
    static void Main()
    {
        Point[] testData = CreateTestData<Point>(50);
        foreach (var item in testData)
        {
            Console.WriteLine(item.X + " " + item.Y);
        }
    }
}
