using ObserverPattern.StockMarket;
using ObserverPattern.WeatherStation;

Console.WriteLine("=== Observer Pattern Demo ===\n");

// =============================================
// Stock Market example
// =============================================
Console.WriteLine("--- Stock Market ---\n");

var exchange = new StockExchange();

var display = new PriceDisplay();
var alert = new PriceAlert("AAPL", 200m);

exchange.PriceChanged += display.OnPriceChanged;
exchange.PriceChanged += alert.OnPriceChanged;

Console.WriteLine("1. Set initial prices:");
exchange.SetPrice("AAPL", 185.50m);
exchange.SetPrice("GOOG", 140.00m);

Console.WriteLine("\n2. AAPL crosses alert threshold:");
exchange.SetPrice("AAPL", 210.75m);

Console.WriteLine("\n3. Unsubscribe PriceDisplay, then update:");
exchange.PriceChanged -= display.OnPriceChanged;
exchange.SetPrice("AAPL", 215.00m);
exchange.SetPrice("GOOG", 201.50m);

// =============================================
// Weather Station example
// =============================================
Console.WriteLine("\n--- Weather Station ---\n");

var station = new WeatherStation();

var phone = new PhoneDisplay();
var stats = new StatisticsDisplay();

station.MeasurementsChanged += phone.OnMeasurementsChanged;
station.MeasurementsChanged += stats.OnMeasurementsChanged;

Console.WriteLine("1. First reading:");
station.SetMeasurements(25.0, 65.0);

Console.WriteLine("\n2. Second reading:");
station.SetMeasurements(28.5, 70.0);

Console.WriteLine("\n3. Third reading:");
station.SetMeasurements(22.0, 55.0);

Console.WriteLine("\n4. Unsubscribe PhoneDisplay, then update:");
station.MeasurementsChanged -= phone.OnMeasurementsChanged;
station.SetMeasurements(30.0, 80.0);
