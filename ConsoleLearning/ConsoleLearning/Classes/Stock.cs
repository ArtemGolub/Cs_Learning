namespace ConsoleLearning.Classes;

public class Stock
{ 
    private decimal _currentPrice;

    public decimal CurrentPrice
    {
        get => _currentPrice;
        init => _currentPrice = value;
    } 
}