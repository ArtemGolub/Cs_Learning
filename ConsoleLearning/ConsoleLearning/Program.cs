class Program
{
    static unsafe void Main()
    {
        int* array = stackalloc int[5];

        for (int i = 0; i < 5; i++)
            array[i] = i * 10;
        
        for (int i = 0; i < 5; i++)
            Console.WriteLine(array[i]);
    }
}