using Mediator.Components;
using Mediator.Models;

namespace Mediator.Mediators;

public interface IChatRoom
{
    public void Notify(Client sender, Event e);
}