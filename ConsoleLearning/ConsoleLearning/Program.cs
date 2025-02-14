using ConsoleLearning.Enumerations;

IEnumerable<string> Foo()
{
    yield return "One";
    yield return "Two";
    yield return "Three";
}

string firstElement = null;
var sequence = Foo();
using (var enumerator = sequence.GetEnumerator())
{
    if (enumerator.MoveNext())
        firstElement = enumerator.Current;
}
Console.WriteLine(firstElement);
