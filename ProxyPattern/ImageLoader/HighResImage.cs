namespace ProxyPattern.ImageLoader;

public class HighResImage : IImage
{
    public string FileName { get; }

    public HighResImage(string fileName)
    {
        FileName = fileName;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        Console.WriteLine($"  [HighResImage] Loading '{FileName}' from disk (expensive operation)...");
    }

    public void Display()
    {
        Console.WriteLine($"  [HighResImage] Displaying '{FileName}'");
    }
}
