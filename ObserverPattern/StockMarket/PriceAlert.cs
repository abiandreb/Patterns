namespace ObserverPattern.StockMarket;

public class PriceAlert(string ticker, decimal threshold)
{
    public void OnPriceChanged(object? sender, StockPriceChangedEventArgs e)
    {
        if (e.Ticker == ticker && e.Price >= threshold)
            Console.WriteLine($"  [PriceAlert] WARNING: {e.Ticker} crossed ${threshold:F2} — now ${e.Price:F2}!");
    }
}
