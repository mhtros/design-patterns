using Mediator.Components;
using Mediator.Mediators;

var chatroom = new ChatRoom();

var c1 = new Client("noobMaster69", chatroom);
var _ = new Client("Kraken", chatroom);
var c3 = new Client("MadDog", chatroom);

c3.SendMessage(null, "Hello guys!");
c1.SendMessage("MadDog", "Hello man! come on start the game");