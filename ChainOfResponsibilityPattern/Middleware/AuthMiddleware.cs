namespace ChainOfResponsibilityPattern.Middleware;

public class AuthMiddleware : Middleware
{
    private static readonly HashSet<string> ValidTokens = ["token-admin", "token-user"];

    public override bool Process(Request request)
    {
        if (request.AuthToken is null || !ValidTokens.Contains(request.AuthToken))
        {
            Console.WriteLine($"  [Auth] REJECTED — invalid or missing token");
            return false;
        }

        Console.WriteLine($"  [Auth] Token validated: {request.AuthToken}");
        request.Metadata["authenticated"] = "true";
        return base.Process(request);
    }
}
