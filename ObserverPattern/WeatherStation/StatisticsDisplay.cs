namespace ObserverPattern.WeatherStation;

public class StatisticsDisplay
{
    private readonly List<double> _temperatures = [];

    public void OnMeasurementsChanged(object? sender, WeatherChangedEventArgs e)
    {
        _temperatures.Add(e.Temperature);

        var min = _temperatures.Min();
        var max = _temperatures.Max();
        var avg = _temperatures.Average();

        Console.WriteLine($"  [StatisticsDisplay] Min: {min:F1}°C, Max: {max:F1}°C, Avg: {avg:F1}°C");
    }
}
