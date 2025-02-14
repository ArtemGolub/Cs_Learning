namespace ConsoleLearning.TryCatch;

public class TryCtachPractice
{
    public void MyMethod(string[] args)
    {
        try
        {
            byte b = byte.Parse(args[0]);
            Console.WriteLine();
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Please provide at least one argument");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please provide a valid argument");
        }
        catch (OverflowException)
        {
            Console.WriteLine("You have given me more than a byte");
        }
    }

}