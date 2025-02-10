namespace ConsoleLearning.Variables;

public class Panda
{
    public string Name;
    public Panda() { }
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
    public Panda(string name) => Name = name;
    public override string ToString() => Name;
}