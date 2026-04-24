namespace AdapterPattern.MediaPlayer;

public class AudioPlayer
{
    private readonly Dictionary<string, IMediaPlayer> _players = [];

    public void RegisterPlayer(IMediaPlayer player)
    {
        _players[player.SupportedFormat] = player;
        Console.WriteLine($"  [AudioPlayer] Registered player for '{player.SupportedFormat}' format");
    }

    public void Play(string format, string fileName)
    {
        if (_players.TryGetValue(format, out var player))
        {
            player.Play(fileName);
        }
        else
        {
            Console.WriteLine($"  [AudioPlayer] Unsupported format: '{format}'");
        }
    }
}
