using NetLearning.LINQ;

namespace NetLearning;

public class Program
{
    public static void Main()
    {
        string[] names =
        {
            "Tom",
            "Dick",
            "Harry",
            "Mary",
            "Jay"
        };



         var temp =
            from name in names
            select new
            {
                Original = name,
                Vowelless = name.Replace("a", "").Replace("e", "")
                    .Replace("i", "").Replace("o", "").Replace("u", "")
            };

        IEnumerable<string> query =
            from item in temp
            where item.Vowelless.Length > 2
            select item.Original;
    }
    
}