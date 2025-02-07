namespace ConsoleLearning.inheritance;

public class House: Asset
{
    public decimal Mortgage;
    public override decimal NetValue { get; }
}