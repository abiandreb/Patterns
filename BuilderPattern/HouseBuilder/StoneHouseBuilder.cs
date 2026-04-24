namespace BuilderPattern.HouseBuilder;

public class StoneHouseBuilder : IHouseBuilder
{
    private string _walls = "stone bricks";
    private string _roof = "clay tiles";
    private int _windows = 4;
    private bool _hasGarage;
    private bool _hasGarden;
    private bool _hasSwimmingPool;

    public IHouseBuilder SetWalls(string material) { _walls = material; return this; }
    public IHouseBuilder SetRoof(string material) { _roof = material; return this; }
    public IHouseBuilder SetWindows(int count) { _windows = count; return this; }
    public IHouseBuilder AddGarage() { _hasGarage = true; return this; }
    public IHouseBuilder AddGarden() { _hasGarden = true; return this; }
    public IHouseBuilder AddSwimmingPool() { _hasSwimmingPool = true; return this; }

    public House Build() => new()
    {
        Walls = _walls,
        Roof = _roof,
        Windows = _windows,
        HasGarage = _hasGarage,
        HasGarden = _hasGarden,
        HasSwimmingPool = _hasSwimmingPool
    };
}
