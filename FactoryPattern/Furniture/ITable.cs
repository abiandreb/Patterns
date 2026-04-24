namespace FactoryPattern.Furniture;

public interface ITable
{
    string Style { get; }
    string PlaceItem(string item);
}
