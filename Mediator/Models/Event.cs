namespace Mediator.Models;

public abstract class Event
{
    public abstract EventType EventType { get; }
}