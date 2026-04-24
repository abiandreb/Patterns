namespace BuilderPattern.HouseBuilder;

// Product
public class House
{
    public string Walls { get; init; } = string.Empty;
    public string Roof { get; init; } = string.Empty;
    public int Windows { get; init; }
    public bool HasGarage { get; init; }
    public bool HasGarden { get; init; }
    public bool HasSwimmingPool { get; init; }

    public override string ToString()
    {
        var features = new List<string>();
        if (HasGarage) features.Add("garage");
        if (HasGarden) features.Add("garden");
        if (HasSwimmingPool) features.Add("swimming pool");

        var extras = features.Count > 0
            ? string.Join(", ", features)
            : "none";

        return $"  Walls: {Walls} | Roof: {Roof} | Windows: {Windows} | Extras: {extras}";
    }
}
