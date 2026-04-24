using FactoryPattern.Furniture;
using FactoryPattern.Notification;

// =============================================
// Factory Method — Notification system
// =============================================
Console.WriteLine("=== Factory Method: Notifications ===\n");

NotificationCreator[] creators =
[
    new EmailCreator(),
    new SmsCreator(),
    new PushCreator()
];

foreach (var creator in creators)
{
    creator.Notify("alice@example.com", "Your order has been shipped!");
    Console.WriteLine();
}

// =============================================
// Abstract Factory — Furniture families
// =============================================
Console.WriteLine("=== Abstract Factory: Furniture ===\n");

IFurnitureFactory[] factories =
[
    new ModernFurnitureFactory(),
    new VictorianFurnitureFactory()
];

foreach (var factory in factories)
{
    Console.WriteLine($"--- {factory.StyleName} Furniture ---");

    var chair = factory.CreateChair();
    var table = factory.CreateTable();
    var sofa = factory.CreateSofa();

    Console.WriteLine($"  {chair.SitOn()}");
    Console.WriteLine($"  {table.PlaceItem("laptop")}");
    Console.WriteLine($"  {sofa.LieOn()}");
    Console.WriteLine();
}
