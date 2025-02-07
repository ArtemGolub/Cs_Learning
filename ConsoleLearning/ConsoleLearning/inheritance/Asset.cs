namespace ConsoleLearning.inheritance;

public class Asset
{
    public required string Name;
    public Asset(){}
    
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
    public Asset(string name) => Name = name;
}