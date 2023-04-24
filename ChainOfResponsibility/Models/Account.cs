namespace ChainOfResponsibility.Models;

public class Account
{
    public Account(string accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public string AccountNumber { get; set; }

    public decimal Balance { get; set; }
}