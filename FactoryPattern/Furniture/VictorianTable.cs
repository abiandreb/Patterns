namespace FactoryPattern.Furniture;

public class VictorianTable : ITable
{
    public string Style => "Victorian";

    public string PlaceItem(string item) => $"Placing {item} on a heavy mahogany Victorian table";
}
