namespace ChainOfResponsibilityPattern.Middleware;

public class Request(string path, string method, string? authToken = null, string? body = null)
{
    public string Path => path;
    public string Method => method;
    public string? AuthToken => authToken;
    public string? Body => body;
    public Dictionary<string, string> Metadata { get; } = [];
}
