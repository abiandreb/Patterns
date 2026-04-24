namespace DecoratorPattern.Coffee;

public class Espresso : ICoffee
{
    public string Description => "Espresso";
    public decimal Cost => 1.50m;
}
