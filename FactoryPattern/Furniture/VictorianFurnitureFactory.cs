namespace FactoryPattern.Furniture;

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public string StyleName => "Victorian";
    public IChair CreateChair() => new VictorianChair();
    public ITable CreateTable() => new VictorianTable();
    public ISofa CreateSofa() => new VictorianSofa();
}
