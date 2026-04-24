namespace VisitorPattern.ExpressionVisitor;

public class Value(int theValue) : Expression
{
    public int TheValue { get; } = theValue;

    public override void Accept(ExpressionVisitor ev) => ev.Visit(this);
}
