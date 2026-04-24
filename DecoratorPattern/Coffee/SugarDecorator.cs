namespace DecoratorPattern.Coffee;

public class SugarDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override string Description => $"{Inner.Description}, sugar";
    public override decimal Cost => Inner.Cost + 0.25m;
}
