namespace Mediator.Models;

public class MessageEvent : Event
{
    public readonly string Message;
    public readonly string? Receiver;

    public MessageEvent(string? receiver, string message)
    {
        Receiver = receiver;
        Message = message;
    }

    public override EventType EventType => EventType.SendMessage;
}