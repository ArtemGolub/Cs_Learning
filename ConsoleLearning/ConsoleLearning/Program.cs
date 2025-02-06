using System.Text;

class Program
{
    private static string myVariable = null;
    private static string someDefault = "Default";
   
    static void Main()
    {
        string s1 = null;
        string s2 = s1 ?? "nothing";
        Console.WriteLine(s2);
        
        myVariable ??= someDefault;
        Console.WriteLine(myVariable);

        StringBuilder sb = null;
        string s = sb?.ToString() ?? "nothing";

        string[] words = null;
        string word = words?[1];
        
        
    }
}
