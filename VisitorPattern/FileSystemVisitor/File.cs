namespace VisitorPattern.FileSystemVisitor;

public class File(string name, long sizeBytes) : IFileSystemNode
{
    public string Name { get; } = name;
    public long SizeBytes { get; } = sizeBytes;

    public void Accept(IFileSystemVisitor visitor) => visitor.Visit(this);
}
