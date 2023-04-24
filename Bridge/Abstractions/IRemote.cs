namespace Bridge.Abstractions;

public interface IRemote
{
    public void TogglePower();

    public void VolumeUp();

    public void VolumeDown();

    public void ChannelUp();

    public void ChannelDown();

    public void Details();
}