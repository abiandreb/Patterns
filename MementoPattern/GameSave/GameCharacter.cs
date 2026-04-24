namespace MementoPattern.GameSave;

// Originator — the game character whose state we snapshot
public class GameCharacter
{
    public string Name { get; }
    public int Health { get; private set; }
    public int Mana { get; private set; }
    public int Level { get; private set; }
    public string Location { get; private set; }

    public GameCharacter(string name, int health, int mana, int level, string location)
    {
        Name = name;
        Health = health;
        Mana = mana;
        Level = level;
        Location = location;
    }

    public void TakeDamage(int amount) => Health = Math.Max(0, Health - amount);
    public void Heal(int amount) => Health = Math.Min(100, Health + amount);
    public void UseMana(int amount) => Mana = Math.Max(0, Mana - amount);
    public void LevelUp() => Level++;
    public void TravelTo(string location) => Location = location;

    public GameMemento Save() => new(Name, Health, Mana, Level, Location, DateTime.Now);

    public void Restore(GameMemento memento)
    {
        Health = memento.Health;
        Mana = memento.Mana;
        Level = memento.Level;
        Location = memento.Location;
    }

    public override string ToString() =>
        $"  {Name} | HP: {Health} | Mana: {Mana} | Lvl: {Level} | Location: {Location}";
}
