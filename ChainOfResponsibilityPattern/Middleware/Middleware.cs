namespace ChainOfResponsibilityPattern.Middleware;

public abstract class Middleware
{
    private Middleware? _next;

    public Middleware Then(Middleware next)
    {
        _next = next;
        return next;
    }

    public virtual bool Process(Request request)
    {
        return _next?.Process(request) ?? true;
    }
}
