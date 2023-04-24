using Visitor;
using Visitor.Elements;
using Visitor.Visitors;

var financialRecords = new List<FinancialRecord>
{
    new ExpenseRecord("Rent", 1000),
    new ExpenseRecord("Utilities", 500),
    new RevenueRecord("Salary", 2000),
    new InvestmentRecord("Savings", 5000),
    new InvestmentRecord("Loan", -2000)
};

var pnl = new ProfitAndLossVisitor();
var bs = new BalanceSheetVisitor();

foreach (var record in financialRecords)
{
    record.Accept(pnl);
    record.Accept(bs);
}

Console.WriteLine("Profit and Loss: " + pnl.GetProfitAndLoss());
Console.WriteLine("Total Assets: " + bs.GetTotalAssets());
Console.WriteLine("Total Liabilities: " + bs.GetTotalLiabilities());
Console.WriteLine("Net Worth: " + bs.GetNetWorth());