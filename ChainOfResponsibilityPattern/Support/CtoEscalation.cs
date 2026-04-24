namespace ChainOfResponsibilityPattern.Support;

public class CtoEscalation : SupportHandler
{
    public override void Handle(Ticket ticket)
    {
        Console.WriteLine($"  [CTO] CRITICAL incident '{ticket.Title}' — assembling war room!");
    }
}
