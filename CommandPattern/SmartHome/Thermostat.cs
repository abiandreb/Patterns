namespace CommandPattern.SmartHome;

public class Thermostat
{
    public int Temperature { get; private set; } = 20;

    public void SetTemperature(int degrees)
    {
        Console.WriteLine($"  [Thermostat] Temperature set from {Temperature}°C to {degrees}°C");
        Temperature = degrees;
    }
}
