using Visitor.Visitors;

namespace Visitor.Elements;

public abstract class FinancialVisitor : IVisitor
{
    public virtual void Visit(ExpenseRecord record)
    {
    }

    public virtual void Visit(RevenueRecord record)
    {
    }

    public virtual void Visit(InvestmentRecord record)
    {
    }
}