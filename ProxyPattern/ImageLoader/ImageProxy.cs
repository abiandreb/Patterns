namespace ProxyPattern.ImageLoader;

public class ImageProxy(string fileName) : IImage
{
    private HighResImage? _realImage;

    public string FileName => fileName;

    public void Display()
    {
        if (_realImage is null)
        {
            Console.WriteLine($"  [Proxy] Lazy-loading image on first access...");
            _realImage = new HighResImage(fileName);
        }
        else
        {
            Console.WriteLine($"  [Proxy] Using cached image...");
        }

        _realImage.Display();
    }
}
