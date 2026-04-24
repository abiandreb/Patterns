namespace ProxyPattern.AccessControl;

public class ProtectedDocumentProxy(IDocument document, User user) : IDocument
{
    public string Title => document.Title;

    public string Read()
    {
        if (user.Role < Role.Employee)
        {
            Console.WriteLine($"  [Proxy] ACCESS DENIED: '{user.Name}' ({user.Role}) cannot read '{Title}'");
            return "[Access Denied]";
        }

        Console.WriteLine($"  [Proxy] Access granted: '{user.Name}' ({user.Role}) reading '{Title}'");
        return document.Read();
    }

    public void Write(string content)
    {
        if (user.Role < Role.Admin)
        {
            Console.WriteLine($"  [Proxy] ACCESS DENIED: '{user.Name}' ({user.Role}) cannot write to '{Title}'");
            return;
        }

        Console.WriteLine($"  [Proxy] Access granted: '{user.Name}' ({user.Role}) writing to '{Title}'");
        document.Write(content);
    }
}
