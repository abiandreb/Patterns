namespace VisitorPattern.FileSystemVisitor;

public class Folder(string name) : IFileSystemNode
{
    public string Name { get; } = name;
    public List<IFileSystemNode> Children { get; } = [];

    public void Accept(IFileSystemVisitor visitor) => visitor.Visit(this);
}
