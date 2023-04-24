namespace ChainOfResponsibility.Models;

public static class Database
{
    public static readonly List<Account> Accounts = new()
    {
        new Account("4111111117444490", 0m),
        new Account("4041370000456459", 0m)
    };
}