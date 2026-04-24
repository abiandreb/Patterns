namespace ChainOfResponsibilityPattern.Middleware;

public class LoggingMiddleware : Middleware
{
    public override bool Process(Request request)
    {
        Console.WriteLine($"  [Logger] {request.Method} {request.Path}");
        return base.Process(request);
    }
}
