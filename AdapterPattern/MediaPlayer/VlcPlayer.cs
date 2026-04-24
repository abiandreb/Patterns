namespace AdapterPattern.MediaPlayer;

/// <summary>
/// Third-party VLC library with an incompatible interface.
/// </summary>
public class VlcPlayer
{
    public void PlayVlc(string fileName)
    {
        Console.WriteLine($"  [VLC Engine] Decoding and playing '{fileName}'");
    }
}
