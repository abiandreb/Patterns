namespace ChainOfResponsibilityPattern.Support;

public class SeniorEngineer : SupportHandler
{
    public override void Handle(Ticket ticket)
    {
        if (ticket.Priority <= Priority.High)
        {
            Console.WriteLine($"  [Senior Engineer] Investigating '{ticket.Title}' — {ticket.Description}");
            return;
        }

        Console.WriteLine($"  [Senior Engineer] '{ticket.Title}' is critical, escalating to management...");
        base.Handle(ticket);
    }
}
