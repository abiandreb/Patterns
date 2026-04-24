# Design Patterns in C#

A collection of classic Gang of Four (GoF) design patterns implemented in modern C# (.NET 10). Each pattern includes multiple real-world examples to illustrate practical usage.

## Patterns

### Creational

| Pattern | Examples | Description |
|---------|----------|-------------|
| [Builder](BuilderPattern) | House Builder (Stone, Wooden) | Fluent builder with Director, method chaining, and immutable products |
| [Factory](FactoryPattern) | Notifications (Factory Method), Furniture (Abstract Factory) | Factory Method for single products; Abstract Factory for product families |
| [Singleton](SingletonPattern) | AppConfig, Logger | Thread-safe implementation using `Lazy<T>` and `Lock` |

### Structural

| Pattern | Examples | Description |
|---------|----------|-------------|
| [Adapter](AdapterPattern) | Media Player (VLC, FLAC), Payment Gateway (Stripe, PayPal) | Bridges incompatible interfaces with unified adapters |
| [Decorator](DecoratorPattern) | Coffee Shop (Milk, Sugar, Whip), Notifications (Slack, SMS) | Dynamically stacks behavior on top of base objects |
| [Proxy](ProxyPattern) | Image Lazy Loading, Role-Based Document Access | Virtual proxy for deferred loading; Protection proxy for access control |

### Behavioral

| Pattern | Examples | Description |
|---------|----------|-------------|
| [Chain of Responsibility](ChainOfResponsibilityPattern) | Support Ticket Escalation, HTTP Middleware Pipeline | Passes requests along a handler chain until one processes it |
| [Command](CommandPattern) | Smart Home Remote, Text Editor | Encapsulates actions as objects with full undo/redo support |
| [Memento](MementoPattern) | Text Editor Undo/Redo, Game Save Slots | Captures and restores object state without exposing internals |
| [Observer](ObserverPattern) | Stock Market Alerts, Weather Station | Event-driven notifications using C# events and delegates |
| [State](StatePattern) | Phone (Off/Locked/Unlocked), Combination Lock | Objects change behavior when their internal state changes |
| [Strategy](StrategyPattern) | Data Serialization (JSON, XML, CSV, Binary), Coffee Brewing | Swaps algorithms at runtime through a common interface |
| [Template Method](TemplateMethodPattern) | Beverage Preparation, Data Exporter, Card Game Combat | Defines algorithm skeleton in a base class; subclasses override specific steps |
| [Visitor](VisitorPattern) | Expression Evaluator, File System Explorer | Adds operations to object structures via double dispatch |

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Getting Started

Clone the repository and run any pattern:

```bash
dotnet run --project BuilderPattern
dotnet run --project FactoryPattern
dotnet run --project StrategyPattern
# ... etc.
```

Or run all projects:

```bash
dotnet build
```

## Project Structure

```
Patterns/
├── AdapterPattern/
│   ├── MediaPlayer/          # VLC & FLAC adapter examples
│   └── Payment/              # Stripe & PayPal adapter examples
├── BuilderPattern/
│   └── HouseBuilder/         # Stone & Wooden house builders
├── ChainOfResponsibilityPattern/
│   ├── Middleware/            # HTTP middleware pipeline
│   └── Support/              # Ticket escalation chain
├── CommandPattern/
│   ├── SmartHome/            # Remote control with undo
│   └── TextEditor/           # Editor with undo/redo
├── DecoratorPattern/
│   ├── Coffee/               # Stackable coffee add-ons
│   └── Notifier/             # Multi-channel notifications
├── FactoryPattern/
│   ├── Furniture/            # Abstract Factory
│   └── Notification/         # Factory Method
├── MementoPattern/
│   ├── GameSave/             # Named save slots
│   └── TextEditor/           # Undo/redo history
├── ObserverPattern/
│   ├── StockMarket/          # Price alerts & displays
│   └── WeatherStation/       # Multi-display weather
├── ProxyPattern/
│   ├── AccessControl/        # Role-based protection proxy
│   └── ImageLoader/          # Lazy-loading virtual proxy
├── SingletonPattern/
│   ├── Configuration/        # App config singleton
│   └── Logging/              # Thread-safe logger
├── StatePattern/
│   ├── CombinationLock/      # Digit-sequence lock
│   └── PhoneState/           # Phone power states
├── StrategyPattern/
│   ├── Beverage/             # Coffee brewing strategies
│   └── Serialization/        # Multi-format serialization
├── TemplateMethodPattern/
│   ├── Beverage/             # Tea & Coffee preparation
│   ├── CardGame/             # Combat damage variants
│   └── DataExporter/         # CSV & JSON exporters
└── VisitorPattern/
    ├── ExpressionVisitor/    # Math expression tree
    └── FileSystemVisitor/    # File system traversal
```

## Key C# Features Used

- Primary constructors
- Init-only properties
- Nullable reference types
- Pattern matching (`is not null`, `switch` expressions)
- Collection expressions (`[]`)
- `Lazy<T>` and `Lock` for thread safety
