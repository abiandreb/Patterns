namespace MementoPattern.GameSave;

// Memento — immutable snapshot of the game character state
public record GameMemento(
    string Name,
    int Health,
    int Mana,
    int Level,
    string Location,
    DateTime SavedAt);
