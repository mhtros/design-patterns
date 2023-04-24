using Visitor.Elements;

namespace Visitor.Visitors;

public class BalanceSheetVisitor : FinancialVisitor
{
    private decimal _totalAssets;
    private decimal _totalLiabilities;

    public override void Visit(InvestmentRecord investment)
    {
        if (investment.Amount > 0)
            _totalAssets += investment.Amount;
        else
            _totalLiabilities -= investment.Amount;
    }

    public decimal GetTotalAssets()
    {
        return _totalAssets;
    }

    public decimal GetTotalLiabilities()
    {
        return _totalLiabilities;
    }

    public decimal GetNetWorth()
    {
        return _totalAssets - _totalLiabilities;
    }
}