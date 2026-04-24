namespace FactoryPattern.Furniture;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public string StyleName => "Modern";
    public IChair CreateChair() => new ModernChair();
    public ITable CreateTable() => new ModernTable();
    public ISofa CreateSofa() => new ModernSofa();
}
