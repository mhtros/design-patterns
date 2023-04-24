using Composite.Components;

namespace Composite.Leafs;

public class Stock : IFinancialProduct
{
    public Stock(string name, int numberOfShares, decimal shareAmount)
    {
        Name = name;
        NumberOfShares = Math.Abs(numberOfShares);
        ShareAmount = Math.Abs(shareAmount);
    }

    public string Name { get; }

    public int NumberOfShares { get; }

    public decimal ShareAmount { get; }

    public decimal Valuation()
    {
        return NumberOfShares * ShareAmount;
    }
}