namespace TemplateMethodPattern.CardGame;

public class PermanentCardDamageGame(Creature[] creatures) : CardGame(creatures)
{
    protected override void Hit(Creature attacker, Creature other)
    {
        other.Health -= attacker.Attack;
    }
}
