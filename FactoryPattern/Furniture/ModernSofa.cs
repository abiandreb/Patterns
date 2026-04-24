namespace FactoryPattern.Furniture;

public class ModernSofa : ISofa
{
    public string Style => "Modern";

    public string LieOn() => "Lying on a compact modern sofa with clean lines";
}
