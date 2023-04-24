using Mediator.Components;
using Mediator.Models;

namespace Mediator.Mediators;

public class ChatRoom : IChatRoom
{
    private readonly List<Client> _clients = new();

    public void Notify(Client sender, Event e)
    {
        if (e.EventType == EventType.Connect) Connect(sender);
        else if (e.EventType == EventType.SendMessage) SendMessage(sender, e);
    }

    private void SendMessage(Client sender, Event e)
    {
        var evt = e as MessageEvent;

        if (evt?.Receiver == null)
        {
            foreach (var client in _clients.Where(client => client.Username != sender.Username))
                client.DisplayMessage(sender.Username, evt?.Message ?? string.Empty);
        }
        else
        {
            var client = _clients.FirstOrDefault(c => c.Username == evt.Receiver);
            if (client is null) throw new NullReferenceException(nameof(client));
            client.DisplayMessage(sender.Username, evt.Message);
        }
    }

    private void Connect(Client sender)
    {
        if (_clients.Exists(x => x.Username == sender.Username)) return;
        _clients.Add(sender);
        foreach (var client in _clients.Where(client => client.Username != sender.Username))
            client.DisplayMessage("SERVER", $"user {sender.Username} has join the room.");
    }
}