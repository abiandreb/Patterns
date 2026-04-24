namespace BuilderPattern.HouseBuilder;

public class HouseDirector(IHouseBuilder builder)
{
    public House BuildSimpleHouse() =>
        builder
            .SetWindows(2)
            .Build();

    public House BuildFamilyHouse() =>
        builder
            .SetWindows(6)
            .AddGarage()
            .AddGarden()
            .Build();

    public House BuildLuxuryMansion() =>
        builder
            .SetWindows(12)
            .AddGarage()
            .AddGarden()
            .AddSwimmingPool()
            .Build();
}
