namespace StrategyPattern.Beverage;

public interface IBrewingStrategy
{
    string Name { get; }
    void Brew(string coffee, int waterMl);
}
