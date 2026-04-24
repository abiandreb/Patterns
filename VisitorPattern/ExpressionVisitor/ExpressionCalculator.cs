namespace VisitorPattern.ExpressionVisitor;

public class ExpressionCalculator : ExpressionVisitor
{
    public double Result { get; private set; }

    public override void Visit(Value value)
    {
        Result = value.TheValue;
    }

    public override void Visit(AdditionExpression ae)
    {
        ae.LHS.Accept(this);
        var left = Result;
        ae.RHS.Accept(this);
        Result = left + Result;
    }

    public override void Visit(SubtractionExpression se)
    {
        se.LHS.Accept(this);
        var left = Result;
        se.RHS.Accept(this);
        Result = left - Result;
    }

    public override void Visit(MultiplicationExpression me)
    {
        me.LHS.Accept(this);
        var left = Result;
        me.RHS.Accept(this);
        Result = left * Result;
    }

    public override void Visit(DivisionExpression de)
    {
        de.LHS.Accept(this);
        var left = Result;
        de.RHS.Accept(this);
        Result = left / Result;
    }
}
