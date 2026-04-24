using ProxyPattern.AccessControl;
using ProxyPattern.ImageLoader;

Console.WriteLine("=== Proxy Pattern Demo ===\n");

// =============================================
// Use Case 1: Virtual Proxy — Lazy Image Loading
// =============================================
Console.WriteLine("1. Virtual Proxy — lazy-loading expensive images:\n");

Console.WriteLine("  Creating image proxies (no loading yet):");
IImage image1 = new ImageProxy("photo_4k.png");
IImage image2 = new ImageProxy("wallpaper_8k.jpg");
Console.WriteLine($"  Created proxies for: {image1.FileName}, {image2.FileName}\n");

Console.WriteLine("  First display of image1 (triggers loading):");
image1.Display();

Console.WriteLine("\n  Second display of image1 (uses cache):");
image1.Display();

Console.WriteLine("\n  First display of image2 (triggers loading):");
image2.Display();

// =============================================
// Use Case 2: Protection Proxy — Access Control
// =============================================
Console.WriteLine("\n=============================================");
Console.WriteLine("\n2. Protection Proxy — role-based document access:\n");

var secretDoc = new SecretDocument("Financial Report Q4", "Revenue: $10M, Profit: $2.5M");

User[] users =
[
    new("Alice", Role.Admin),
    new("Bob", Role.Employee),
    new("Charlie", Role.Guest)
];

foreach (var user in users)
{
    Console.WriteLine($"  --- {user.Name} ({user.Role}) ---");
    var proxy = new ProtectedDocumentProxy(secretDoc, user);

    var content = proxy.Read();
    if (content != "[Access Denied]")
        Console.WriteLine($"  Content: {content}");

    proxy.Write("Updated content");
    Console.WriteLine();
}
