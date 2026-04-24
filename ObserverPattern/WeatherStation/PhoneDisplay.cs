namespace ObserverPattern.WeatherStation;

public class PhoneDisplay
{
    public void OnMeasurementsChanged(object? sender, WeatherChangedEventArgs e) =>
        Console.WriteLine($"  [PhoneDisplay] Current conditions: {e.Temperature:F1}°C and {e.Humidity:F1}% humidity");
}
