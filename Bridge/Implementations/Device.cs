namespace Bridge.Implementations;

public abstract class Device : IDevice
{
    private int _currentChannel = 1;
    public virtual Dictionary<int, string> Channels { get; set; } = new();
    public virtual int MaxVolume { get; set; }
    public virtual int Volume { get; set; }
    public virtual bool IsPowered { get; set; }

    public (int, string) GetCurrentChannel()
    {
        var name = Channels[_currentChannel];
        return (_currentChannel, name);
    }

    public void SetChannel(int channelNumber)
    {
        if (Channels.ContainsKey(channelNumber) is false) throw new ArgumentException($"{channelNumber} is not exists");

        _currentChannel = channelNumber;
    }
}