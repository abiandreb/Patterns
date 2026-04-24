namespace StrategyPattern.Serialization;

public class DataStore
{
    private readonly List<Person> _people = [];
    private ISerializationStrategy _strategy;

    public DataStore(ISerializationStrategy strategy) => _strategy = strategy;

    public void SetStrategy(ISerializationStrategy strategy) => _strategy = strategy;

    public void Add(Person person) => _people.Add(person);

    public string Serialize() => _strategy.Serialize(_people);

    public List<Person> Deserialize(string data) => _strategy.Deserialize(data);
}
