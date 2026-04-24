using TemplateMethodPattern.Beverage;
using TemplateMethodPattern.CardGame;
using TemplateMethodPattern.DataExporter;

Console.WriteLine("=== Template Method Pattern Demo ===\n");

// --- Beverage ---

Console.WriteLine("1. Preparing tea:");
var tea = new Tea();
tea.Prepare();

Console.WriteLine("\n2. Preparing coffee (with condiments):");
var coffee = new Coffee();
coffee.Prepare();

Console.WriteLine("\n3. Preparing black coffee (no condiments — hook override):");
var blackCoffee = new Coffee(withCondiments: false);
blackCoffee.Prepare();

// --- Data Exporter ---

var records = new List<Record>
{
    new("Alice", 30, "Kyiv"),
    new("Bob", 25, "Lviv"),
    new("Charlie", 35, "Odesa")
};

Console.WriteLine("\n4. CSV Export:");
var csv = new CsvExporter();
Console.WriteLine(csv.Export(records));

Console.WriteLine("\n5. JSON Export:");
var json = new JsonExporter();
Console.WriteLine(json.Export(records));

// --- Card Game ---

Console.WriteLine("\n6. Temporary damage — 1/1 vs 2/2:");
var tempCreatures = new[] { new Creature(1, 1), new Creature(2, 2) };
var tempGame = new TemporaryCardDamageGame(tempCreatures);
var tempWinner = tempGame.Combat(0, 1);
Console.WriteLine($"  Winner: {(tempWinner == -1 ? "no clear winner" : $"creature {tempWinner} ({tempCreatures[tempWinner]})")}");

Console.WriteLine("\n7. Permanent damage — 1/2 vs 1/3:");
var permCreatures = new[] { new Creature(1, 2), new Creature(1, 3) };
var permGame = new PermanentCardDamageGame(permCreatures);
var permWinner = permGame.Combat(0, 1);
Console.WriteLine($"  Winner: {(permWinner == -1 ? "no clear winner" : $"creature {permWinner} ({permCreatures[permWinner]})")}");

Console.WriteLine("\n8. Temporary vs Permanent — same 2/3 vs 2/3:");
var creaturesA = new[] { new Creature(2, 3), new Creature(2, 3) };
var creaturesB = new[] { new Creature(2, 3), new Creature(2, 3) };
var tempResult = new TemporaryCardDamageGame(creaturesA).Combat(0, 1);
var permResult = new PermanentCardDamageGame(creaturesB).Combat(0, 1);
Console.WriteLine($"  Temporary: {(tempResult == -1 ? "no clear winner (both survive)" : $"creature {tempResult}")}");
Console.WriteLine($"  Permanent: {(permResult == -1 ? "no clear winner (both die)" : $"creature {permResult}")}");

