namespace ChainOfResponsibilityPattern.Support;

public class JuniorSupport : SupportHandler
{
    public override void Handle(Ticket ticket)
    {
        if (ticket.Priority <= Priority.Medium)
        {
            Console.WriteLine($"  [Junior Support] Handling '{ticket.Title}' — {ticket.Description}");
            return;
        }

        Console.WriteLine($"  [Junior Support] '{ticket.Title}' is too complex, escalating...");
        base.Handle(ticket);
    }
}
