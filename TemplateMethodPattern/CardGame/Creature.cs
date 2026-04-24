namespace TemplateMethodPattern.CardGame;

public class Creature(int attack, int health)
{
    public int Attack { get; set; } = attack;
    public int Health { get; set; } = health;

    public override string ToString() => $"Creature({Attack}/{Health})";
}
