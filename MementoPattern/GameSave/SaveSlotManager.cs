namespace MementoPattern.GameSave;

// Caretaker — manages named save slots without knowing memento internals
public class SaveSlotManager
{
    private readonly Dictionary<string, GameMemento> _slots = new();

    public void SaveToSlot(string slotName, GameCharacter character)
    {
        _slots[slotName] = character.Save();
        Console.WriteLine($"  Saved to slot \"{slotName}\"");
    }

    public bool LoadFromSlot(string slotName, GameCharacter character)
    {
        if (!_slots.TryGetValue(slotName, out var memento)) return false;

        character.Restore(memento);
        Console.WriteLine($"  Loaded from slot \"{slotName}\" (saved at {memento.SavedAt:HH:mm:ss})");
        return true;
    }

    public IReadOnlyCollection<string> SlotNames => _slots.Keys;
}
