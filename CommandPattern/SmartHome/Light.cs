namespace CommandPattern.SmartHome;

public class Light(string location)
{
    public bool IsOn { get; private set; }
    public int Brightness { get; private set; }

    public void On()
    {
        IsOn = true;
        Brightness = 100;
        Console.WriteLine($"  [{location} Light] Turned ON (brightness: {Brightness}%)");
    }

    public void Off()
    {
        IsOn = false;
        Brightness = 0;
        Console.WriteLine($"  [{location} Light] Turned OFF");
    }

    public void Dim(int level)
    {
        Brightness = level;
        Console.WriteLine($"  [{location} Light] Dimmed to {Brightness}%");
    }
}
