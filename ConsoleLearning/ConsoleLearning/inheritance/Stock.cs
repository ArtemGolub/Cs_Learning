namespace ConsoleLearning.inheritance;

public class Stock: Asset
{
    public long SharesOwned;
    public decimal CurrentPrice;
    
    public override decimal NetValue => CurrentPrice * SharesOwned;
}