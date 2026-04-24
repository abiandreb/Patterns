namespace FactoryPattern.Furniture;

public class VictorianSofa : ISofa
{
    public string Style => "Victorian";

    public string LieOn() => "Lying on a plush Victorian sofa with velvet upholstery";
}
