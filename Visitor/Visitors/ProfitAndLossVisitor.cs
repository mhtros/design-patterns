using Visitor.Elements;

namespace Visitor.Visitors;

public class ProfitAndLossVisitor : FinancialVisitor
{
    private decimal _totalExpenses;
    private decimal _totalRevenue;

    public override void Visit(ExpenseRecord expense)
    {
        _totalExpenses += expense.Amount;
    }

    public override void Visit(RevenueRecord revenue)
    {
        _totalRevenue += revenue.Amount;
    }

    public decimal GetProfitAndLoss()
    {
        return _totalRevenue - _totalExpenses;
    }
}