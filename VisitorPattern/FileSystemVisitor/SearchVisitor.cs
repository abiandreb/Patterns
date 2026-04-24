namespace VisitorPattern.FileSystemVisitor;

public class SearchVisitor(string extension) : IFileSystemVisitor
{
    public List<string> Found { get; } = [];

    public void Visit(File file)
    {
        if (file.Name.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
            Found.Add(file.Name);
    }

    public void Visit(Folder folder)
    {
        foreach (var child in folder.Children)
            child.Accept(this);
    }
}
