using Adapter.Model;

namespace Adapter.Adapter;

public interface IEcbChartImageAdapter
{
    public void SaveExchangeRatesAsChartBar(IReadOnlyCollection<Currency> rates, string filename);
}