namespace ConsoleLearning.Modificators;

public class NameSplitter
{
    public static void Split(string name, out string firstNames, out string lastName)
    {
        int i = name.IndexOf(' ');
        firstNames = name.Substring(0, i);
        lastName = name.Substring(i + 1);
    }


}