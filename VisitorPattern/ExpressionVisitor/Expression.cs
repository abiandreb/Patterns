namespace VisitorPattern.ExpressionVisitor;

public abstract class Expression
{
    public abstract void Accept(ExpressionVisitor ev);
}
