using NetLearning.Collections;

namespace NetLearning;

public class Program
{
    public static void Main()
    {
        Zoo zoo = new Zoo();
        zoo.Animals.Add(new Animal("Kangoroo", 19));
        zoo.Animals.Add(new Animal("Lion", 10));
        
        Console.WriteLine(zoo.Animals[0].Popularity);
        Console.WriteLine(zoo.Animals["Lion"].Popularity);
    }
}