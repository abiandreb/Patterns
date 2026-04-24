namespace ObserverPattern.StockMarket;

public class StockPriceChangedEventArgs(string ticker, decimal price) : EventArgs
{
    public string Ticker => ticker;
    public decimal Price => price;
}
