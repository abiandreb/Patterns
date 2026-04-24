namespace TemplateMethodPattern.Beverage;

public class Tea : Beverage
{
    protected override void Brew() => Console.WriteLine("  Steeping the tea bag...");
    protected override void AddCondiments() => Console.WriteLine("  Adding lemon...");
}
