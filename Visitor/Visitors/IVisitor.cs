using Visitor.Elements;

namespace Visitor.Visitors;

public interface IVisitor
{
    public void Visit(ExpenseRecord record);
    public void Visit(RevenueRecord record);
    public void Visit(InvestmentRecord record);
}