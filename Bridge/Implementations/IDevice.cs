namespace Bridge.Implementations;

public interface IDevice
{
    public Dictionary<int, string> Channels { get; set; }

    public int MaxVolume { get; set; }

    public int Volume { get; set; }

    public bool IsPowered { get; set; }

    public (int, string) GetCurrentChannel();

    public void SetChannel(int channelNumber);
}