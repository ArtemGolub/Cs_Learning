namespace NetLearning.Formatting_and_Parsing;

public class ToString_Parse<T> where T : IParsable<T>
{
    public string? Convert(T data)
    {
        string? s = data?.ToString();
        return string.IsNullOrEmpty(s) ? throw new Exception("Null or Empty string") : s;
    }

    public T DeConvert(string? s)
    {
        if(string.IsNullOrEmpty(s))
          throw new Exception("Null or Empty string");
        
        T data = T.Parse(s, null);
        return data;
    }
}