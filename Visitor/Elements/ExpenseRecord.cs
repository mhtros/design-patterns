using Visitor.Visitors;

namespace Visitor.Elements;

public class ExpenseRecord : FinancialRecord
{
    public ExpenseRecord(string name, decimal amount) : base(name, amount)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}