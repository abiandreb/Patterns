namespace FactoryPattern.Furniture;

public class ModernTable : ITable
{
    public string Style => "Modern";

    public string PlaceItem(string item) => $"Placing {item} on a minimalist glass table";
}
