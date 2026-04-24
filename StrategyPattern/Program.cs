using StrategyPattern.Beverage;
using StrategyPattern.Serialization;

Console.WriteLine("=== Strategy Pattern Demo ===\n");

var store = new DataStore(new JsonStrategy());
store.Add(new Person("Alice", 30, "Kyiv"));
store.Add(new Person("Bob", 25, "Lviv"));
store.Add(new Person("Charlie", 35, "Odesa"));

// --- JSON ---
Console.WriteLine("1. JSON serialization:");
var json = store.Serialize();
Console.WriteLine(json);

var fromJson = store.Deserialize(json);
Console.WriteLine($"\n   Deserialized {fromJson.Count} records: {string.Join(", ", fromJson)}");

// --- XML (runtime strategy swap) ---
store.SetStrategy(new XmlStrategy());
Console.WriteLine("\n2. XML serialization (swapped strategy at runtime):");
var xml = store.Serialize();
Console.WriteLine(xml);

var fromXml = store.Deserialize(xml);
Console.WriteLine($"   Deserialized {fromXml.Count} records: {string.Join(", ", fromXml)}");

// --- CSV ---
store.SetStrategy(new CsvStrategy());
Console.WriteLine("\n3. CSV serialization:");
var csv = store.Serialize();
Console.WriteLine(csv);

var fromCsv = store.Deserialize(csv);
Console.WriteLine($"\n   Deserialized {fromCsv.Count} records: {string.Join(", ", fromCsv)}");

// --- Binary ---
store.SetStrategy(new BinaryStrategy());
Console.WriteLine("\n4. Binary serialization (Base64-encoded):");
var binary = store.Serialize();
Console.WriteLine(binary);

var fromBinary = store.Deserialize(binary);
Console.WriteLine($"\n   Deserialized {fromBinary.Count} records: {string.Join(", ", fromBinary)}");

// =============================================
// Beverage example
// =============================================
Console.WriteLine("\n=== Beverage Brewing Strategy ===\n");

var coffeeMaker = new CoffeeMaker(new EspressoStrategy());
coffeeMaker.MakeCoffee("Arabica", 30);

// --- Swap to Drip at runtime ---
Console.WriteLine();
coffeeMaker.SetStrategy(new DripStrategy());
coffeeMaker.MakeCoffee("Colombian Blend", 250);

// --- Swap to French Press at runtime ---
Console.WriteLine();
coffeeMaker.SetStrategy(new FrenchPressStrategy());
coffeeMaker.MakeCoffee("Robusta", 350);
