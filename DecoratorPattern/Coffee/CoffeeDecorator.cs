namespace DecoratorPattern.Coffee;

public abstract class CoffeeDecorator(ICoffee coffee) : ICoffee
{
    public abstract string Description { get; }
    public abstract decimal Cost { get; }

    protected ICoffee Inner => coffee;
}
