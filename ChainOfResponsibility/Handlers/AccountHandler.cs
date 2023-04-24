using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

public abstract class AccountHandler : IAccountHandler
{
    protected IAccountHandler? NextHandler;

    public void Next(IAccountHandler nextHandler)
    {
        NextHandler = nextHandler;
    }

    public abstract void Handle(AccountRequest request);
}