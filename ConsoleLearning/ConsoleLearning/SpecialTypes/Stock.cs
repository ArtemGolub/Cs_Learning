namespace ConsoleLearning.SpecialTypes;

public class Stock(string symbol)
{
    private readonly string _symbol = symbol;
    private decimal _price;

    public event EventHandler<PriceChangedEventArgs> PriceChanged;

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if(_price == value) return;
            decimal oldPrice = _price;
            _price = value;
            OnPriceChanged(new PriceChangedEventArgs(oldPrice, _price));
        }
    }
}