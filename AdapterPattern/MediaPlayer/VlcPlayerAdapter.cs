namespace AdapterPattern.MediaPlayer;

public class VlcPlayerAdapter(VlcPlayer vlcPlayer) : IMediaPlayer
{
    public string SupportedFormat => "vlc";

    public void Play(string fileName)
    {
        Console.WriteLine($"  [Adapter] Converting request for VLC format...");
        vlcPlayer.PlayVlc(fileName);
    }
}
