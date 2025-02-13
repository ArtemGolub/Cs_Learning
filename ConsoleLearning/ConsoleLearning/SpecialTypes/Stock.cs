namespace ConsoleLearning.SpecialTypes;

public class Stock(string symbol)
{
    private readonly string _symbol = symbol;
    private decimal _price;

    private EventHandler<PriceChangedEventArgs> _priceChanged;
    public event EventHandler<PriceChangedEventArgs> PriceChanged
    {
        add { _priceChanged += value; }
        remove { _priceChanged -= value; }
    }

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        _priceChanged?.Invoke(this, e);
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