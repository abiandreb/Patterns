namespace ObserverPattern.WeatherStation;

public class WeatherChangedEventArgs(double temperature, double humidity) : EventArgs
{
    public double Temperature => temperature;
    public double Humidity => humidity;
}
