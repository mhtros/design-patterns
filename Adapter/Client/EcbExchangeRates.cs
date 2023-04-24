using System.Globalization;
using System.Xml;
using Adapter.Adapter;
using Adapter.Model;

namespace Adapter.Client;

public class EcbExchangeRates
{
    private static readonly HttpClient Client = new();

    private readonly IEcbChartImageAdapter _adapter;

    public EcbExchangeRates(IEcbChartImageAdapter adapter)
    {
        _adapter = adapter;
        Task.Run(GetExchangeRatesAsync).Wait();
    }

    public DateTime Date { get; private set; }

    public IReadOnlyCollection<Currency>? Rates { get; private set; }

    private async Task GetExchangeRatesAsync()
    {
        var rawXml = await FetchEcbExchangesRatesRawXmlAsync();

        var xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(rawXml);

        // Using xPath expression to retrieve the node containing the time attribute 
        var dateNode = xmlDocument.SelectSingleNode("//*[@time]");

        var rawDate = dateNode?.Attributes?["time"]?.Value;
        var dateTime = DateTime.Parse(rawDate ?? throw new InvalidOperationException());

        // Using xPath expression to retrieve the nodes containing the currency attribute
        var currencyRatesNodeList = xmlDocument.SelectNodes("//*[@currency]");

        Date = dateTime;

        if (currencyRatesNodeList == null) return;

        var currencyRates = new List<Currency>();

        foreach (XmlNode node in currencyRatesNodeList)
        {
            var rawCurrencyCode = node?.Attributes?["currency"]?.Value!;
            var rawRate = node?.Attributes?["rate"]?.Value;

            var succeed = decimal.TryParse(rawRate,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out var parsedRate);

            if (succeed == false) throw new ArithmeticException($"Cannot convert {rawRate} to decimal");

            var item = new Currency(rawCurrencyCode, parsedRate);
            currencyRates.Add(item);
        }

        Date = dateTime;
        Rates = currencyRates;
    }

    private static async Task<string> FetchEcbExchangesRatesRawXmlAsync()
    {
        try
        {
            const string url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml";

            using var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var rawXml = await response.Content.ReadAsStringAsync();

            return rawXml;
        }
        catch (HttpRequestException e)
        {
            throw new ApplicationException($"Cannot fetch ecb exchanges rates: {e.Message}", e);
        }
    }

    public void SaveAsChartBar()
    {
        var filename =
            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\exchange_rates_{Date:yyyyMMdd}.png";
        _adapter.SaveExchangeRatesAsChartBar(Rates!, filename);
    }
}