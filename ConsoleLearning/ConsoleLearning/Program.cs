using ConsoleLearning.SpecialTypes;

int[] values = { 1, 2, 3};
Util.Transfrom(values, MathOperations.Square);

foreach (int index in values)
{
    Console.WriteLine(index + " ");
}

