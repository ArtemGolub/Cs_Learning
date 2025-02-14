using System.Net;

namespace ConsoleLearning.TryCatch;

public class TryCtachPractice
{
    public int Parse(string input)
    {
        int result;
        if(!TryParse(input, out result))
        {
            throw new FormatException();
        }
        return result;
    }

    public bool TryParse(string input, out int result)
    {
        if (int.TryParse(input, out result))
        {
            return true; // Преобразование успешно
        }
        return false; // Преобразование невозможно
    }

}