using Mediator.Mediators;
using Mediator.Models;

namespace Mediator.Components;

public class Client
{
    private readonly IChatRoom _chatroom;
    public readonly string Username;

    public Client(string username, IChatRoom chatroom)
    {
        Username = username;
        _chatroom = chatroom;
        Connect();
    }

    private void Connect()
    {
        _chatroom.Notify(this, new ConnectEvent());
        Console.WriteLine($"Welcome {Username}");
    }

    public void SendMessage(string? receiver, string message)
    {
        var evt = new MessageEvent(receiver, message);
        _chatroom.Notify(this, evt);
    }

    public void DisplayMessage(string from, string message)
    {
        Console.WriteLine($"[{from}] to [{Username}]: {message}");
    }
}