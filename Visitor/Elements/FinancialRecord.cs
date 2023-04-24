using Visitor.Visitors;

namespace Visitor.Elements;

public abstract class FinancialRecord
{
    protected FinancialRecord(string name, decimal amount)
    {
        Name = name;
        Amount = amount;
    }

    public string Name { get; }
    public decimal Amount { get; }

    public abstract void Accept(IVisitor visitor);
}