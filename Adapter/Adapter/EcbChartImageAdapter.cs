using Adapter.ExternalLibrary;
using Adapter.Model;

namespace Adapter.Adapter;

public class EcbChartImageAdapter : IEcbChartImageAdapter
{
    private readonly IChartGenerator _chartGenerator;

    public EcbChartImageAdapter(IChartGenerator chartGenerator)
    {
        _chartGenerator = chartGenerator;
    }

    public void SaveExchangeRatesAsChartBar(IReadOnlyCollection<Currency> rates, string filename)
    {
        if (rates == null || !rates.Any())
            throw new ArgumentNullException(nameof(rates), "Ecb exchange rates cannot be null");

        var count = rates.Count;

        var values = new double[count];
        var labels = new string[count];

        for (var i = 0; i < count; i++)
        {
            var curRate = rates.ElementAt(i);
            labels[i] = curRate.Code;
            values[i] = (double) curRate.ExchangeRate;
        }

        _chartGenerator.GenerateChartBar(values, labels, filename);
    }
}