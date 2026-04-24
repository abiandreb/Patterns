using BuilderPattern;
using BuilderPattern.HouseBuilder;

Console.WriteLine("=== Builder Pattern Demo ===\n");

Console.WriteLine("1. Director builds a luxury stone mansion:");
var director = new HouseDirector(new StoneHouseBuilder());
Console.WriteLine(director.BuildLuxuryMansion());

Console.WriteLine("\n2. Director builds a luxury wooden mansion:");
var woodenDirector = new HouseDirector(new WoodenHouseBuilder());
Console.WriteLine(woodenDirector.BuildLuxuryMansion());

Console.WriteLine("\n3. Custom house built directly (no Director):");
var custom = new StoneHouseBuilder()
    .SetWalls("marble")
    .SetRoof("copper")
    .SetWindows(8)
    .AddGarden()
    .Build();
Console.WriteLine(custom);
