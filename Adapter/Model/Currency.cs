namespace Adapter.Model;

public class Currency
{
    public Currency(string code, decimal exchangeRate)
    {
        Code = code;
        ExchangeRate = exchangeRate;
    }

    public string Code { get; }
    public decimal ExchangeRate { get; }
}