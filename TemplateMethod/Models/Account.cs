namespace TemplateMethod.Models;

public class Account
{
    public Account(decimal balance, Guid id)
    {
        Balance = balance;
        Id = id;
    }

    public Guid Id { get; set; }

    public decimal Balance { get; set; }
}