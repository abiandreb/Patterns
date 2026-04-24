namespace VisitorPattern.FileSystemVisitor;

public interface IFileSystemNode
{
    string Name { get; }
    void Accept(IFileSystemVisitor visitor);
}
