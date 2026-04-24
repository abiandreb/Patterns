namespace FactoryPattern.Furniture;

public class VictorianChair : IChair
{
    public string Style => "Victorian";

    public string SitOn() => "Sitting on an ornate Victorian chair with carved wooden arms";
}
