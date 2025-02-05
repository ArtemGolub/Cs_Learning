using ConsoleLearning.Variables;

class Program
{
    int instanceValue = 10; // Поле экземпляра класса — хранится в куче
    static int staticValue = 20; // Статическое поле — хранится в куче но существует пока не завершится процесс

    static void Main()
    {
        int localValue = 30; // Локальная переменная типа значения — хранится в стеке
        Point point = new Point { X = 1, Y = 2 }; // Структура в локальной переменной (стек)

        Console.WriteLine($"Локальная переменная: {localValue}");
        Console.WriteLine($"Point.X: {point.X}, Point.Y: {point.Y}");
    }
}