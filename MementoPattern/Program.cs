using MementoPattern.GameSave;
using MementoPattern.TextEditor;

// =============================================
// Memento — Text Editor with Undo / Redo
// =============================================
Console.WriteLine("=== Memento: Text Editor ===\n");

var editor = new TextEditor();
var history = new EditorHistory(editor);

history.SaveState();
editor.Type("Hello");
Console.WriteLine($"  Typed:  {editor}");

history.SaveState();
editor.Type(", World");
Console.WriteLine($"  Typed:  {editor}");

history.SaveState();
editor.Type("!");
Console.WriteLine($"  Typed:  {editor}");

history.SaveState();
editor.DeleteRange(5, 7);
Console.WriteLine($"  Delete: {editor}");

Console.WriteLine($"\n  Undo stack: {history.UndoCount} | Redo stack: {history.RedoCount}");

history.Undo();
Console.WriteLine($"  Undo:   {editor}");

history.Undo();
Console.WriteLine($"  Undo:   {editor}");

history.Redo();
Console.WriteLine($"  Redo:   {editor}");

history.Undo();
history.Undo();
history.Undo();
Console.WriteLine($"  Undo x3: {editor}");

// =============================================
// Memento — Game Save Slots
// =============================================
Console.WriteLine("\n=== Memento: Game Save ===\n");

var hero = new GameCharacter("Archer", health: 100, mana: 50, level: 1, location: "Village");
var saves = new SaveSlotManager();

Console.WriteLine(hero);
saves.SaveToSlot("start", hero);

hero.TravelTo("Dark Forest");
hero.TakeDamage(30);
hero.UseMana(15);
Console.WriteLine($"\n  After exploring the forest:");
Console.WriteLine(hero);
saves.SaveToSlot("forest", hero);

hero.TravelTo("Dragon Lair");
hero.TakeDamage(60);
hero.UseMana(25);
hero.LevelUp();
Console.WriteLine($"\n  After fighting the dragon:");
Console.WriteLine(hero);

// Oops — load the forest save
Console.WriteLine();
saves.LoadFromSlot("forest", hero);
Console.WriteLine(hero);

// Or go all the way back to the start
Console.WriteLine();
saves.LoadFromSlot("start", hero);
Console.WriteLine(hero);
