using ConsoleLearning.Classes;

Rectangle rectangle = new Rectangle(3,4);
var (_, height) = rectangle; // деконструирование
Console.WriteLine($" + {height}");