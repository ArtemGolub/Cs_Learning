namespace ConsoleLearning.Interfaces;

public class Redoable: IRedoable
{
    public void Do()
    {
        Console.WriteLine("IRedoable");
    }

    int IUndoable.Do()
    {
        Console.WriteLine("IUNdoable");
        return 42;
    }

}