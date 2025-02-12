using ConsoleLearning.SpecialTypes;



Stock stock = new Stock("THPW");
stock.Price = 27.10M;

stock.PriceChanged += StockPriceChanged;
stock.Price = 31.59M;


void StockPriceChanged(object sender, PriceChangedEventArgs e)
{
    if((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
        Console.WriteLine("Allert, 10% stock price increase!");
}