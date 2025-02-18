public class TestClass
{
    unsafe delegate*<string, int> functionPointer = &GetLength;
    static int GetLength(string s) => s.Length;
    public unsafe int MyLength()
        => functionPointer("Hello world");
}


class Program
{
    static void Main()
    {
        TestClass test = new TestClass();
        Console.WriteLine(test.MyLength());
    }
}