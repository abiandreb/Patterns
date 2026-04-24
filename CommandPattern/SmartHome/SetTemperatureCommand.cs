namespace CommandPattern.SmartHome;

public class SetTemperatureCommand(Thermostat thermostat, int newTemp) : ICommand
{
    private int _previousTemp;

    public string Name => $"Set Temperature to {newTemp}°C";

    public void Execute()
    {
        _previousTemp = thermostat.Temperature;
        thermostat.SetTemperature(newTemp);
    }

    public void Undo()
    {
        thermostat.SetTemperature(_previousTemp);
    }
}
