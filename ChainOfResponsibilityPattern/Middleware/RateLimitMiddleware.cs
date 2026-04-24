namespace ChainOfResponsibilityPattern.Middleware;

public class RateLimitMiddleware(int maxRequests) : Middleware
{
    private int _requestCount;

    public override bool Process(Request request)
    {
        _requestCount++;

        if (_requestCount > maxRequests)
        {
            Console.WriteLine($"  [RateLimit] REJECTED — limit of {maxRequests} requests exceeded");
            return false;
        }

        Console.WriteLine($"  [RateLimit] Request {_requestCount}/{maxRequests} allowed");
        return base.Process(request);
    }
}
