namespace ObserverPattern.WeatherStation;

public class WeatherStation
{
    public event EventHandler<WeatherChangedEventArgs>? MeasurementsChanged;

    public void SetMeasurements(double temperature, double humidity)
    {
        Console.WriteLine($"  [WeatherStation] New reading: {temperature:F1}°C, {humidity:F1}% humidity");
        MeasurementsChanged?.Invoke(this, new WeatherChangedEventArgs(temperature, humidity));
    }
}
