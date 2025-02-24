using NetLearning.EqualityComparers;

namespace NetLearning;

public class Program
{
    public static void Main()
    {
        var wishList = new List<Wish>();
        wishList.Add(new Wish("Peace", 2));
        wishList.Add(new Wish("Wealth", 3));
        wishList.Add(new Wish("Love", 2));
        wishList.Add(new Wish("3 more wishes", 1));
        
        wishList.Sort(new PriorityComparer());

        foreach (Wish wish in wishList)
            Console.Write($"{wish.Name} |");
    }
    
}