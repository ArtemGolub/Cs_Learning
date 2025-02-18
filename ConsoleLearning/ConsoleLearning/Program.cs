using System.Runtime.CompilerServices;

class Program
{
    [SkipLocalsInit]
    static void Main()
    {
        int[] data = new int[10];
        Console.WriteLine(data[0]);
    }
}