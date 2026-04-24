namespace VisitorPattern.ExpressionVisitor;

public class AdditionExpression(Expression lhs, Expression rhs) : Expression
{
    public Expression LHS { get; } = lhs;
    public Expression RHS { get; } = rhs;

    public override void Accept(ExpressionVisitor ev) => ev.Visit(this);
}
