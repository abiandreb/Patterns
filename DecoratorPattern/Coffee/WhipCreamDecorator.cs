namespace DecoratorPattern.Coffee;

public class WhipCreamDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override string Description => $"{Inner.Description}, whip cream";
    public override decimal Cost => Inner.Cost + 0.75m;
}
