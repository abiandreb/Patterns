namespace VisitorPattern.FileSystemVisitor;

public class TreePrinter : IFileSystemVisitor
{
    private int _depth;
    private readonly List<string> _lines = [];

    public void Visit(File file)
    {
        _lines.Add($"{Indent()}{file.Name} ({file.SizeBytes} bytes)");
    }

    public void Visit(Folder folder)
    {
        _lines.Add($"{Indent()}{folder.Name}/");
        _depth++;
        foreach (var child in folder.Children)
            child.Accept(this);
        _depth--;
    }

    public string GetResult() => string.Join('\n', _lines);

    private string Indent() => new(' ', _depth * 2);
}
