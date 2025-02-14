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

    void ReadFile()
    {
        StreamReader reader = null;
        try
        {
            reader = File.OpenText("file.txt");
            if (reader.EndOfStream) return;
            Console.WriteLine(reader.ReadToEnd());
        }
        finally
        {
            if(reader != null) reader.Dispose();
        }
    }

    void ReadFileUsing()
    {
        if (File.Exists("file.txt"))
        {
            using var reader = File.OpenText("file.txt");
            Console.WriteLine(reader.ReadToEnd());
        }
    }

}