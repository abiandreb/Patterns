namespace VisitorPattern.FileSystemVisitor;

public interface IFileSystemVisitor
{
    void Visit(File file);
    void Visit(Folder folder);
}
