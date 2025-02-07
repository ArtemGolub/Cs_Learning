namespace ConsoleLearning.Classes;

public struct InitializedStruct (string name, string lastName)
{
    private readonly string _name;
    private readonly string _lastName;
    private readonly int _age;
    
    public InitializedStruct(string name, string lastName, int age) : this( name, lastName)
    {
        _name = name;
        _lastName = lastName;
        _age = age;
    }
    public void PrintName() => Console.WriteLine($"{_name} {_lastName} {_age}");
}