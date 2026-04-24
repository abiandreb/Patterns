namespace VisitorPattern.FileSystemVisitor;

public class SizeCalculator : IFileSystemVisitor
{
    public long TotalBytes { get; private set; }

    public void Visit(File file)
    {
        TotalBytes += file.SizeBytes;
    }

    public void Visit(Folder folder)
    {
        foreach (var child in folder.Children)
            child.Accept(this);
    }
}
