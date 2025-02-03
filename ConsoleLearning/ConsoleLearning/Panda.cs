namespace ConsoleLearning;

public class Panda
{
    public string Name;
    public static int Population;
    
    public Panda(string name)
    {
        Name = name;
        Population += 1;
    }
}