namespace StrategyPattern.Beverage;

public class CoffeeMaker
{
    private IBrewingStrategy _strategy;

    public CoffeeMaker(IBrewingStrategy strategy) => _strategy = strategy;

    public void SetStrategy(IBrewingStrategy strategy) => _strategy = strategy;

    public void MakeCoffee(string coffee, int waterMl)
    {
        Console.WriteLine($"  [{_strategy.Name}] Making coffee with {coffee}:");
        _strategy.Brew(coffee, waterMl);
    }
}
