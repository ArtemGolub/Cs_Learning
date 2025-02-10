namespace ConsoleLearning.Interfaces;

public class RichTextBox: TextBox
{
    public override void Undo() => Console.WriteLine("RichTextBox.Undo");
}