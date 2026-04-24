namespace FactoryPattern.Furniture;

public class ModernChair : IChair
{
    public string Style => "Modern";

    public string SitOn() => "Sitting on a sleek modern chair with chrome legs";
}
