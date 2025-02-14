using ConsoleLearning.Enumerations;

foreach (string s in Foo())
    Console.WriteLine(s);


IEnumerable<string> Foo()
{
    yield return "One";
    yield return "Two";
    yield return "Three";
}

