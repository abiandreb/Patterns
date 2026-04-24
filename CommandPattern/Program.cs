using CommandPattern.SmartHome;
using CommandPattern.TextEditor;

Console.WriteLine("=== Command Pattern Demo ===\n");

// =============================================
// Use Case 1: Smart Home Remote Control
// =============================================
Console.WriteLine("1. Smart Home — remote control with undo:\n");

var livingRoomLight = new Light("Living Room");
var thermostat = new Thermostat();
var remote = new RemoteControl();

remote.Press(new LightOnCommand(livingRoomLight));
remote.Press(new SetTemperatureCommand(thermostat, 24));
remote.Press(new LightOffCommand(livingRoomLight));

Console.WriteLine();
Console.WriteLine("  Undoing last 2 commands:");
remote.UndoLast();
remote.UndoLast();

// =============================================
// Use Case 2: Text Editor with Undo/Redo
// =============================================
Console.WriteLine("\n=============================================");
Console.WriteLine("\n2. Text Editor — command-based editing with undo/redo:\n");

var doc = new Document();
var editor = new DocumentEditor(doc);

Console.WriteLine("  Writing a poem:");
editor.Execute(new InsertLineCommand(doc, 0, "Roses are red,"));
editor.Execute(new InsertLineCommand(doc, 1, "Violets are blue,"));
editor.Execute(new InsertLineCommand(doc, 2, "Design patterns are cool,"));
editor.Execute(new InsertLineCommand(doc, 3, "And so are you."));
editor.Print();

Console.WriteLine("\n  Replacing line 3:");
editor.Execute(new ReplaceLineCommand(doc, 2, "C# is elegant,"));
editor.Print();

Console.WriteLine("\n  Undo (restore original line 3):");
editor.Undo();
editor.Print();

Console.WriteLine("\n  Redo (apply replacement again):");
editor.Redo();
editor.Print();

Console.WriteLine("\n  Deleting line 4:");
editor.Execute(new DeleteLineCommand(doc, 3));
editor.Print();

Console.WriteLine("\n  Undo delete:");
editor.Undo();
editor.Print();
