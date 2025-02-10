namespace ConsoleLearning.Interfaces;

public class TextBox: IUndoable
{
    public virtual void Undo() => Console.WriteLine("TextBox.Undo");
}