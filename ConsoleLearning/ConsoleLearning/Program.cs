static void Calculate(int a, int b, out int sum, out int product)
{
    sum = a + b; // Присваиваем значение
    product = a * b; // Присваиваем значение
}


int x = 3, y = 4;
int sum, product; // Объявляем, но не инициализируем

Calculate(x, y, out sum, out product); // Передаём параметры с модификатором out

Console.WriteLine($"Sum: {sum}, Product: {product}");
// Вывод: Sum: 7, Product: 12


static void PrintNumbers(params int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}


PrintNumbers(1, 2, 3, 4, 5); // Передаём несколько значений
PrintNumbers(10); // Передаём одно значение
PrintNumbers(); // Не передаём ничего