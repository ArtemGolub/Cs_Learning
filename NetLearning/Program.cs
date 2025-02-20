
foreach (Enum value in Enum.GetValues(typeof(BorderSides)))
{
    Console.WriteLine(value);
}

Array values = Enum.GetValues(typeof(BorderSides));
object? lastElement = values.GetValue(values.Length - 1);
Console.WriteLine(lastElement);