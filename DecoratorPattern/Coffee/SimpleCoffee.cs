namespace DecoratorPattern.Coffee;

public class SimpleCoffee : ICoffee
{
    public string Description => "Simple coffee";
    public decimal Cost => 1.00m;
}
