namespace StrategyPattern.Beverage;

public class EspressoStrategy : IBrewingStrategy
{
    public string Name => "Espresso";

    public void Brew(string coffee, int waterMl)
    {
        Console.WriteLine($"  Grinding {coffee} to a fine powder...");
        Console.WriteLine($"  Forcing {waterMl}ml of hot water through the grounds at 9 bars of pressure...");
        Console.WriteLine("  Espresso ready — rich and concentrated!");
    }
}
