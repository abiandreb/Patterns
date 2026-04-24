namespace ObserverPattern.StockMarket;

public class PriceDisplay
{
    public void OnPriceChanged(object? sender, StockPriceChangedEventArgs e) =>
        Console.WriteLine($"  [PriceDisplay] {e.Ticker}: ${e.Price:F2}");
}
