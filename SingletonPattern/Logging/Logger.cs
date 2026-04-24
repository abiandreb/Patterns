namespace SingletonPattern.Logging;

// Thread-safe singleton using Lazy<T>
public sealed class Logger
{
    private static readonly Lazy<Logger> Instance = new(() => new Logger());

    private readonly List<LogEntry> _entries = [];
    private readonly Lock _lock = new();

    private Logger()
    {
        Console.WriteLine("  [Logger] Instance created (this should appear only once)");
    }

    public static Logger Current => Instance.Value;

    public void Log(LogLevel level, string message)
    {
        var entry = new LogEntry(DateTime.Now, level, message);
        lock (_lock) { _entries.Add(entry); }
        Console.WriteLine($"  [{entry.Level}] {entry.Message}");
    }

    public void Debug(string message) => Log(LogLevel.Debug, message);
    public void Info(string message) => Log(LogLevel.Info, message);
    public void Warning(string message) => Log(LogLevel.Warning, message);
    public void Error(string message) => Log(LogLevel.Error, message);

    public IReadOnlyList<LogEntry> Entries
    {
        get { lock (_lock) { return _entries.ToList(); } }
    }
}
