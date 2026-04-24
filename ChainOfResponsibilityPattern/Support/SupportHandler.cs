namespace ChainOfResponsibilityPattern.Support;

public abstract class SupportHandler
{
    private SupportHandler? _next;

    public SupportHandler SetNext(SupportHandler next)
    {
        _next = next;
        return next;
    }

    public virtual void Handle(Ticket ticket)
    {
        if (_next is not null)
            _next.Handle(ticket);
        else
            Console.WriteLine($"  [End of Chain] No handler could process: '{ticket.Title}'");
    }
}
