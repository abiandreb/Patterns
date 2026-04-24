namespace ObserverPattern.StockMarket;

public class StockExchange
{
    private readonly Dictionary<string, decimal> _prices = [];

    public event EventHandler<StockPriceChangedEventArgs>? PriceChanged;

    public void SetPrice(string ticker, decimal price)
    {
        _prices[ticker] = price;
        PriceChanged?.Invoke(this, new StockPriceChangedEventArgs(ticker, price));
    }
}
