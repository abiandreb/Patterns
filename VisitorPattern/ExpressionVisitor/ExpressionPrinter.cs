using System.Text;

namespace VisitorPattern.ExpressionVisitor;

public class ExpressionPrinter : ExpressionVisitor
{
    private readonly StringBuilder _sb = new();

    public override void Visit(Value value)
    {
        _sb.Append(value.TheValue);
    }

    public override void Visit(AdditionExpression ae)
    {
        _sb.Append('(');
        ae.LHS.Accept(this);
        _sb.Append('+');
        ae.RHS.Accept(this);
        _sb.Append(')');
    }

    public override void Visit(SubtractionExpression se)
    {
        _sb.Append('(');
        se.LHS.Accept(this);
        _sb.Append('-');
        se.RHS.Accept(this);
        _sb.Append(')');
    }

    public override void Visit(MultiplicationExpression me)
    {
        me.LHS.Accept(this);
        _sb.Append('*');
        me.RHS.Accept(this);
    }

    public override void Visit(DivisionExpression de)
    {
        de.LHS.Accept(this);
        _sb.Append('/');
        de.RHS.Accept(this);
    }

    public override string ToString() => _sb.ToString();
}
