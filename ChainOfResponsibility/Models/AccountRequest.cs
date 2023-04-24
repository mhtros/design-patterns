namespace ChainOfResponsibility.Models;

public class AccountRequest
{
    public int RequestType { get; set; }
    public decimal Amount { get; set; }
    public string? SenderAccountNumber { get; set; }
    public string? ReceiverAccountNumber { get; set; }
}