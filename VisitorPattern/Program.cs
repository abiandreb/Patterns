using VisitorPattern.ExpressionVisitor;
using VisitorPattern.FileSystemVisitor;
using File = VisitorPattern.FileSystemVisitor.File;

Console.WriteLine("=== Visitor Pattern Demo ===\n");

// --- Expression Visitor ---

// (10 + 5) * 2 - 30 / (2 + 1)
var expr = new SubtractionExpression(
    new MultiplicationExpression(
        new AdditionExpression(new Value(10), new Value(5)),
        new Value(2)),
    new DivisionExpression(
        new Value(30),
        new AdditionExpression(new Value(2), new Value(1))));

Console.WriteLine("1. Expression Printer:");
var printer1 = new ExpressionPrinter();
expr.Accept(printer1);
Console.WriteLine($"  {printer1}");

Console.WriteLine("\n2. Expression Calculator:");
var calc = new ExpressionCalculator();
expr.Accept(calc);
Console.WriteLine($"  {printer1} = {calc.Result}");

// --- File System Visitor ---
Console.WriteLine("\n3. File System Tree:");
var root = new Folder("project");

var src = new Folder("src");
src.Children.Add(new File("Program.cs", 1200));
src.Children.Add(new File("Utils.cs", 800));

var assets = new Folder("assets");
assets.Children.Add(new File("logo.png", 50000));
assets.Children.Add(new File("style.css", 3200));

root.Children.Add(src);
root.Children.Add(assets);
root.Children.Add(new File("README.md", 400));

var printer = new TreePrinter();
root.Accept(printer);
Console.WriteLine(printer.GetResult());

var sizer = new SizeCalculator();
root.Accept(sizer);
Console.WriteLine($"\nTotal size: {sizer.TotalBytes} bytes");

var search = new SearchVisitor(".cs");
root.Accept(search);
Console.WriteLine($"Found .cs files: {string.Join(", ", search.Found)}");

