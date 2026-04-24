namespace AdapterPattern.MediaPlayer;

public interface IMediaPlayer
{
    string SupportedFormat { get; }
    void Play(string fileName);
}
