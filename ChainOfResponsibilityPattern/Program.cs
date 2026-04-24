using ChainOfResponsibilityPattern.Middleware;
using ChainOfResponsibilityPattern.Support;

Console.WriteLine("=== Chain of Responsibility Pattern Demo ===\n");

// =============================================
// Use Case 1: Support Ticket Escalation
// =============================================
Console.WriteLine("1. Support Desk — ticket escalation chain:\n");

var faqBot = new FaqBot();
var junior = new JuniorSupport();
var senior = new SeniorEngineer();
var cto = new CtoEscalation();

faqBot.SetNext(junior).SetNext(senior).SetNext(cto);

Ticket[] tickets =
[
    new("Password reset", Priority.Low, "User forgot password"),
    new("Slow dashboard", Priority.Medium, "Page takes 10s to load"),
    new("API returning 500", Priority.High, "Production endpoint failing"),
    new("Data breach detected", Priority.Critical, "Unauthorized access to user data"),
    new("Login help", Priority.Low, "Can't find login page")
];

foreach (var ticket in tickets)
{
    Console.WriteLine($"\n  Ticket: [{ticket.Priority}] {ticket.Title}");
    faqBot.Handle(ticket);
}

// =============================================
// Use Case 2: HTTP Middleware Pipeline
// =============================================
Console.WriteLine("\n\n=============================================");
Console.WriteLine("\n2. Middleware Pipeline — request processing chain:\n");

var logging = new LoggingMiddleware();
var auth = new AuthMiddleware();
var rateLimit = new RateLimitMiddleware(3);

logging.Then(auth).Then(rateLimit);

Request[] requests =
[
    new("/api/users", "GET", "token-admin"),
    new("/api/orders", "POST", "token-user", """{"item": "book"}"""),
    new("/api/secret", "GET"),
    new("/api/users", "GET", "token-admin"),
    new("/api/users", "GET", "token-admin"),
    new("/api/users", "GET", "token-admin")
];

foreach (var request in requests)
{
    Console.WriteLine($"\n  → {request.Method} {request.Path} (token: {request.AuthToken ?? "none"})");
    var success = logging.Process(request);
    Console.WriteLine($"  Result: {(success ? "200 OK" : "BLOCKED")}");
}
