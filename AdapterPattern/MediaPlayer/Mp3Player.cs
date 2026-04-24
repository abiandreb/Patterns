namespace AdapterPattern.MediaPlayer;

public class Mp3Player : IMediaPlayer
{
    public string SupportedFormat => "mp3";

    public void Play(string fileName)
    {
        Console.WriteLine($"  [MP3 Player] Playing '{fileName}'");
    }
}
