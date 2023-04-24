using TemplateMethod.ConcreteClasses;

var skyBankCalculator = new SkyBankInterestAccrualsCalculator();
var oceanicCreditCalculator = new OceanicCreditInterestAccrualsCalculator();
var summitSavingsCalculator = new SummitSavingsInterestAccrualsCalculator();

var accountId = new Guid("44c02f0e-908d-4eea-877f-906d7a959b5e");

Console.WriteLine($"Adding interest accruals for account {accountId} at SkyBank...");
skyBankCalculator.AddInterestAccruals(accountId);

Console.WriteLine($"Adding interest accruals for account {accountId} at OceanicCredit...");
oceanicCreditCalculator.AddInterestAccruals(accountId);

Console.WriteLine($"Adding interest accruals for account {accountId} at SummitSavings...");
summitSavingsCalculator.AddInterestAccruals(accountId);