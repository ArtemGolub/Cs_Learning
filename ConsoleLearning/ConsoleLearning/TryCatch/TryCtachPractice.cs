using System.Net;

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
        catch (FormatException ex)
        {
            Console.WriteLine($"{ex} : Please provide at least one argument");
        }
        catch (IndexOutOfRangeException) // можно опустить переменную
        {
            Console.WriteLine("Please provide at least one argument");
        }
        catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout) // Можно создавать фильтры исключений
        {
            
        }
        catch // Опуская переменную перехватываются все исключения
        {
        } 
    }

}