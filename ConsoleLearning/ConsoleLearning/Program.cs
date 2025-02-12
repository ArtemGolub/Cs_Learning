using ConsoleLearning.SpecialTypes;

Func<int, int> square = x => x * x;

int result = ExecuteDelegate(square, 4);
Console.WriteLine(result);


int ExecuteDelegate(Func<int, int> func, int value)
{
    return func(value);
}