namespace NetLearning.Equality;

public record Test(int X, int Y)
{
    public virtual bool Equals(Test? t) => 
        t != null && 
        t.X == X && 
        t.Y == Y;
}