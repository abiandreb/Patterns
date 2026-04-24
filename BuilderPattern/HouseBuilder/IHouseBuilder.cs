namespace BuilderPattern.HouseBuilder;

public interface IHouseBuilder
{
    IHouseBuilder SetWalls(string material);
    IHouseBuilder SetRoof(string material);
    IHouseBuilder SetWindows(int count);
    IHouseBuilder AddGarage();
    IHouseBuilder AddGarden();
    IHouseBuilder AddSwimmingPool();
    House Build();
}
