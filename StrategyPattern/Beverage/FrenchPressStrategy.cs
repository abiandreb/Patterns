namespace StrategyPattern.Beverage;

public class FrenchPressStrategy : IBrewingStrategy
{
    public string Name => "French Press";

    public void Brew(string coffee, int waterMl)
    {
        Console.WriteLine($"  Grinding {coffee} to a coarse grind...");
        Console.WriteLine($"  Steeping grounds in {waterMl}ml of hot water for 4 minutes...");
        Console.WriteLine("  Pressing the plunger down...");
        Console.WriteLine("  French press ready — bold and full-bodied!");
    }
}
