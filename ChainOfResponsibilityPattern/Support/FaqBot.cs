namespace ChainOfResponsibilityPattern.Support;

public class FaqBot : SupportHandler
{
    private static readonly HashSet<string> KnownIssues =
        ["password reset", "login help", "account setup"];

    public override void Handle(Ticket ticket)
    {
        if (ticket.Priority == Priority.Low &&
            KnownIssues.Any(k => ticket.Title.Contains(k, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"  [FAQ Bot] Auto-resolved '{ticket.Title}' with knowledge base article");
            return;
        }

        Console.WriteLine($"  [FAQ Bot] Cannot handle '{ticket.Title}', escalating...");
        base.Handle(ticket);
    }
}
