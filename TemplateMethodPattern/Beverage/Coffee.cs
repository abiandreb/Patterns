namespace TemplateMethodPattern.Beverage;

public class Coffee : Beverage
{
    private readonly bool _withCondiments;

    public Coffee(bool withCondiments = true) => _withCondiments = withCondiments;

    protected override void Brew() => Console.WriteLine("  Dripping coffee through filter...");
    protected override void AddCondiments() => Console.WriteLine("  Adding sugar and milk...");
    protected override bool WantsCondiments() => _withCondiments;
}
