namespace ConsoleLearning.Classes;

public struct InitializedStruct (string name, string lastName)
{
    readonly string lastName = (lastName == null)
        ? throw new ArgumentException("lastName cannot be null")
        : lastName;
}