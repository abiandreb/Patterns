namespace AdapterPattern.MediaPlayer;

/// <summary>
/// Third-party FLAC library with an incompatible interface.
/// </summary>
public class FlacDecoder
{
    public void DecodeAndPlay(string fileName)
    {
        Console.WriteLine($"  [FLAC Decoder] Lossless decoding and playing '{fileName}'");
    }
}
