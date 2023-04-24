using Composite.Components;

namespace Composite.Composites;

public class Portfolio : IFinancialProduct
{
    private readonly List<IFinancialProduct> _products = new();

    public decimal Valuation()
    {
        return _products.Sum(product => product.Valuation());
    }

    public void AddProduct(IFinancialProduct product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(IFinancialProduct product)
    {
        _products.Remove(product);
    }
}