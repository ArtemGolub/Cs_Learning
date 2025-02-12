namespace ConsoleLearning.SpecialTypes;

public delegate void PriceChangedHandler(
    decimal oldPrice,
    decimal newPrice);

public class PriceChangedEventArgs(decimal lastPrice, decimal newPrice) : EventArgs
{
    public readonly decimal LastPrice = lastPrice;
    public readonly decimal NewPrice = newPrice;
}