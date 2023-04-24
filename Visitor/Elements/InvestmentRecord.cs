using Visitor.Visitors;

namespace Visitor.Elements;

public class InvestmentRecord : FinancialRecord
{
    public InvestmentRecord(string name, decimal amount) : base(name, amount)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}