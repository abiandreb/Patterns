namespace AdapterPattern.MediaPlayer;

public class FlacPlayerAdapter(FlacDecoder decoder) : IMediaPlayer
{
    public string SupportedFormat => "flac";

    public void Play(string fileName)
    {
        Console.WriteLine($"  [Adapter] Converting request for FLAC format...");
        decoder.DecodeAndPlay(fileName);
    }
}
