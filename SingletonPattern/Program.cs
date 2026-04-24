using SingletonPattern.Configuration;
using SingletonPattern.Logging;

// =============================================
// Singleton — AppConfig
// =============================================
Console.WriteLine("=== Singleton: AppConfig ===\n");

var config1 = AppConfig.Current;
config1["DatabaseHost"] = "localhost";
config1["DatabasePort"] = "5432";
config1["AppName"] = "PatternDemo";

Console.WriteLine($"  config1 settings: {config1}");

// Grab the same instance from a different reference
var config2 = AppConfig.Current;
Console.WriteLine($"  config2 settings: {config2}");
Console.WriteLine($"  Same instance? {ReferenceEquals(config1, config2)}");

// =============================================
// Singleton — Logger
// =============================================
Console.WriteLine("\n=== Singleton: Logger ===\n");

var logger1 = Logger.Current;
logger1.Info("Application started");
logger1.Debug("Loading configuration...");

// Different reference, same instance
var logger2 = Logger.Current;
logger2.Warning("Cache miss for key 'session'");
logger2.Error("Failed to connect to payment gateway");

Console.WriteLine($"\n  Same instance? {ReferenceEquals(logger1, logger2)}");
Console.WriteLine($"  Total log entries: {Logger.Current.Entries.Count}");

// =============================================
// Thread safety demonstration
// =============================================
Console.WriteLine("\n=== Thread Safety Test ===\n");

var tasks = Enumerable.Range(0, 5).Select(i =>
    Task.Run(() =>
    {
        var logger = Logger.Current;
        logger.Info($"Message from thread {Environment.CurrentManagedThreadId}");
    }));

Task.WaitAll(tasks.ToArray());

Console.WriteLine($"\n  Total log entries after threading: {Logger.Current.Entries.Count}");
