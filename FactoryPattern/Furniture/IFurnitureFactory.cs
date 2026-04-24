namespace FactoryPattern.Furniture;

// Abstract Factory — declares creation methods for each product in the family
public interface IFurnitureFactory
{
    string StyleName { get; }
    IChair CreateChair();
    ITable CreateTable();
    ISofa CreateSofa();
}
