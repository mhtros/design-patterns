using Composite.Composites;
using Composite.Leafs;

var husbandPortfolio = new Portfolio();
var husbandAccount = new MoneyAccount(200.23m);
var husbandStocks = new Stock("Apple", 100, 138.38m);
husbandPortfolio.AddProduct(husbandAccount);
husbandPortfolio.AddProduct(husbandStocks);

var wifePortfolio = new Portfolio();
var wifeAccount = new MoneyAccount(550.47m);
var wifeStock = new Stock("Microsoft", 2000, 228.56m);
wifePortfolio.AddProduct(wifeAccount);
wifePortfolio.AddProduct(wifeStock);

var familyPortfolio = new Portfolio();
var familyAccount = new MoneyAccount(15_000m);
familyPortfolio.AddProduct(husbandPortfolio);
familyPortfolio.AddProduct(wifePortfolio);
familyPortfolio.AddProduct(familyAccount);

var totalValue = familyPortfolio.Valuation();

Console.WriteLine($"Total Value of Family portfolio is {totalValue:N}");