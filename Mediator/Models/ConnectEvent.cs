namespace Mediator.Models;

public class ConnectEvent : Event
{
    public override EventType EventType => EventType.Connect;
}