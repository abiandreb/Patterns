namespace SingletonPattern.Logging;

public record LogEntry(DateTime Timestamp, LogLevel Level, string Message);
