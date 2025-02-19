namespace NetLearning.Formatting_and_Parsing;

public class ToString_Parse<T> where T : IParsable<T>
{
    public string? Convert(T data)
    {
        string? s = data?.ToString();
        return string.IsNullOrEmpty(s) ? throw new Exception("Null or Empty string") : s;
    }

    public void DeConvert(string? s, out T data)
    {
        if(string.IsNullOrEmpty(s))
          throw new Exception("Null or Empty string");
        
        data = T.Parse(s, null);
    }
}