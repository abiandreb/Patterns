namespace StrategyPattern.Beverage;

public class DripStrategy : IBrewingStrategy
{
    public string Name => "Drip";

    public void Brew(string coffee, int waterMl)
    {
        Console.WriteLine($"  Grinding {coffee} to a medium grind...");
        Console.WriteLine($"  Slowly dripping {waterMl}ml of hot water through a paper filter...");
        Console.WriteLine("  Drip coffee ready — clean and smooth!");
    }
}
