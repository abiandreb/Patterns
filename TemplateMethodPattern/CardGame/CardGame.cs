namespace TemplateMethodPattern.CardGame;

public abstract class CardGame(Creature[] creatures)
{
    protected Creature[] Creatures { get; } = creatures;
    
    public int Combat(int creature1, int creature2)
    {
        var first = Creatures[creature1];
        var second = Creatures[creature2];

        Hit(first, second);
        Hit(second, first);

        bool firstAlive = first.Health > 0;
        bool secondAlive = second.Health > 0;

        if (firstAlive == secondAlive) return -1;
        return firstAlive ? creature1 : creature2;
    }

    // Abstract step — attacker hits the other creature
    protected abstract void Hit(Creature attacker, Creature other);
}
