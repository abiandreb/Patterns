namespace VisitorPattern.ExpressionVisitor;

public abstract class ExpressionVisitor
{
    public abstract void Visit(Value value);
    public abstract void Visit(AdditionExpression ae);
    public abstract void Visit(SubtractionExpression se);
    public abstract void Visit(MultiplicationExpression me);
    public abstract void Visit(DivisionExpression de);
}
