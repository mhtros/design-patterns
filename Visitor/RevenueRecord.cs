using Visitor.Elements;
using Visitor.Visitors;

namespace Visitor;

public class RevenueRecord : FinancialRecord
{
    public RevenueRecord(string name, decimal amount) : base(name, amount)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}