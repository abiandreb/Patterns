using DecoratorPattern.Coffee;
using DecoratorPattern.Notifier;

Console.WriteLine("=== Decorator Pattern Demo ===\n");

// =============================================
// Use Case 1: Coffee Shop Orders
// =============================================
Console.WriteLine("1. Coffee Shop — dynamically adding toppings:\n");

ICoffee order1 = new SimpleCoffee();
Console.WriteLine($"  {order1.Description} = ${order1.Cost}");

order1 = new MilkDecorator(order1);
Console.WriteLine($"  {order1.Description} = ${order1.Cost}");

order1 = new SugarDecorator(order1);
Console.WriteLine($"  {order1.Description} = ${order1.Cost}");

Console.WriteLine();

ICoffee order2 = new WhipCreamDecorator(
    new MilkDecorator(
        new MilkDecorator(
            new Espresso())));
Console.WriteLine($"  {order2.Description} = ${order2.Cost}");

// =============================================
// Use Case 2: Notification Channels
// =============================================
Console.WriteLine("\n=============================================");
Console.WriteLine("\n2. Notifications — stacking multiple channels:\n");

Console.WriteLine("  Sending via email only:");
INotifier notifier = new EmailNotifier("dev@example.com");
notifier.Send("Server is healthy");

Console.WriteLine("\n  Sending via email + Slack:");
notifier = new SlackDecorator(
    new EmailNotifier("dev@example.com"), "alerts");
notifier.Send("CPU usage above 80%");

Console.WriteLine("\n  Sending via email + Slack + SMS (critical alert):");
notifier = new SmsDecorator(
    new SlackDecorator(
        new EmailNotifier("dev@example.com"), "critical"),
    "+1-555-0123");
notifier.Send("DATABASE IS DOWN!");
