using Adapter.Adapter;
using Adapter.Client;
using Adapter.ExternalLibrary;

var service = new ChartImageGenerator();
var adapter = new EcbChartImageAdapter(service);
var client = new EcbExchangeRates(adapter);

Console.WriteLine($"Euro exchange rates for {client.Date:dd/MM/yyyy}");

foreach (var currency in client.Rates!) Console.WriteLine($"{currency.Code}: {currency.ExchangeRate}");

client.SaveAsChartBar();