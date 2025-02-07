using ConsoleLearning.inheritance;

Asset newAsset = new Asset("Name");
Asset a2 = new Asset
{
    Name = "Name 2" 
};


public class B
{
    public int x = 1; // Выполняется третьим

    public B(int x)
    {
        // выполняется четвертым
    }
}
public class D : B
{
    private int y = 1; // Выполняется первым
    public D(int x) : base (x + 1) // Выполняется вторым
    {
        // Выполняется пятым
    }
}