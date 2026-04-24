namespace ProxyPattern.ImageLoader;

public interface IImage
{
    string FileName { get; }
    void Display();
}
