namespace ProxyPattern.AccessControl;

public interface IDocument
{
    string Title { get; }
    string Read();
    void Write(string content);
}
