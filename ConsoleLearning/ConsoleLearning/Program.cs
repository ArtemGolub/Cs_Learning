
public interface IAdditionOperators<TSelf, TOther, TResult>
    where TSelf : IAdditionOperators<TSelf, TOther, TResult>?
{
    static abstract TResult operator +(TSelf left, TOther right);
    public static virtual TResult operator checked +
        (TSelf left, TOther right) => left + right;
}


public class Program
{

    public static void Main()
    {

    }
}
