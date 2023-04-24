using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

public interface IAccountHandler
{
    public void Next(IAccountHandler nextHandler);

    public void Handle(AccountRequest request);
}