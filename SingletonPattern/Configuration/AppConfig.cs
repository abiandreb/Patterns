namespace SingletonPattern.Configuration;

// Thread-safe singleton using Lazy<T>
public sealed class AppConfig
{
    private static readonly Lazy<AppConfig> Instance = new(() => new AppConfig());

    private readonly Dictionary<string, string> _settings = new();

    private AppConfig()
    {
        Console.WriteLine("  [AppConfig] Instance created (this should appear only once)");
    }

    public static AppConfig Current => Instance.Value;

    public string this[string key]
    {
        get => _settings.TryGetValue(key, out var value) ? value : throw new KeyNotFoundException(key);
        set => _settings[key] = value;
    }

    public bool ContainsKey(string key) => _settings.ContainsKey(key);

    public IReadOnlyDictionary<string, string> All => _settings;

    public override string ToString() =>
        string.Join(", ", _settings.Select(kv => $"{kv.Key}={kv.Value}"));
}
