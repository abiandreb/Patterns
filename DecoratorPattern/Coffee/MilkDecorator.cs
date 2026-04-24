namespace DecoratorPattern.Coffee;

public class MilkDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override string Description => $"{Inner.Description}, milk";
    public override decimal Cost => Inner.Cost + 0.50m;
}
