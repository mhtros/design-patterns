using Bridge.Abstractions;
using Bridge.Implementations;

var tv = new Tv();
var radio = new Radio();

var tvRemote = new Remote(tv);
var radioRemote = new Remote(radio);

Zapping(tvRemote);
Zapping(radioRemote);

void Zapping(IRemote rmt)
{
    rmt.Details();
    rmt.VolumeUp();
    rmt.VolumeUp();
    rmt.Details();
    rmt.ChannelUp();
    rmt.Details();
    rmt.ChannelUp();
    rmt.Details();
    rmt.ChannelDown();
    rmt.Details();
}