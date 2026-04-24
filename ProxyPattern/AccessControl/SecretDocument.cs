namespace ProxyPattern.AccessControl;

public class SecretDocument(string title, string content) : IDocument
{
    public string Title => title;

    public string Read() => content;

    public void Write(string newContent)
    {
        content = newContent;
    }
}
