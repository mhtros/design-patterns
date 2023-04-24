using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Commons;

public static class Audit
{
    public static string AccountsAudits()
    {
        return string.Join("\n", Database.Accounts.Select(x => $"{x.AccountNumber}: {x.Balance:N}$"));
    }
}