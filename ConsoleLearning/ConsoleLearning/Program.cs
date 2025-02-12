using ConsoleLearning.SpecialTypes;

MathOperations mathOperations = new MathOperations();
int[] values = {1,2,3};

Transform (values, mathOperations.Square);

foreach (int value in values)
    Console.WriteLine(value + " ");
void Transform(int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
        values[i] = t(values[i]);
}