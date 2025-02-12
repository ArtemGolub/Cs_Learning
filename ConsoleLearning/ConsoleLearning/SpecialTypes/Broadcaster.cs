using System.Runtime.CompilerServices;

namespace ConsoleLearning.SpecialTypes;

public delegate void PriceChangedHandler(decimal oldPrice, 
                                        decimal newPrice);

public class PriceChangedEventArgs(decimal lastPrice, decimal newPrice) : EventArgs
{
    public readonly decimal LastPrice = lastPrice;
    public readonly decimal NewPrice = newPrice;
}


public class Stock
{
    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }
}

public class Broadcaster
{
    public event PriceChangedHandler PriceChanged;
}