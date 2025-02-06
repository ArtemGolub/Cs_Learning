for (int i = 0, prevFib = 1, cureFib = 1; i < 10; i++)
{
    Console.WriteLine(prevFib);
    int newFib = prevFib + cureFib;
    prevFib = cureFib;
    cureFib = newFib;
}