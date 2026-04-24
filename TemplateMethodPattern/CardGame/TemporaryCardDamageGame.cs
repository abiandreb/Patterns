namespace TemplateMethodPattern.CardGame;

public class TemporaryCardDamageGame(Creature[] creatures) : CardGame(creatures)
{
    protected override void Hit(Creature attacker, Creature other)
    {
        var oldHealth = other.Health;
        other.Health -= attacker.Attack;
        if (other.Health > 0)
            other.Health = oldHealth;
    }
}
