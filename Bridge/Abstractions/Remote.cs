using Bridge.Implementations;

namespace Bridge.Abstractions;

public class Remote : IRemote
{
    private readonly IDevice _device;


    public Remote(IDevice device)
    {
        _device = device;
    }

    public void TogglePower()
    {
        _device.IsPowered = !_device.IsPowered;
    }

    public void VolumeUp()
    {
        if (_device.Volume < _device.MaxVolume) _device.Volume++;
    }

    public void VolumeDown()
    {
        if (_device.Volume >= 0) _device.Volume--;
    }

    public void ChannelUp()
    {
        var (channelNo, _) = _device.GetCurrentChannel();
        if (channelNo == _device.Channels.Count)
            _device.SetChannel(1);
        else _device.SetChannel(channelNo + 1);
    }

    public void ChannelDown()
    {
        var (channelNo, _) = _device.GetCurrentChannel();
        if (channelNo == 1)
            _device.SetChannel(_device.Channels.Count);
        else _device.SetChannel(channelNo - 1);
    }

    public void Details()
    {
        var (no, name) = _device.GetCurrentChannel();
        Console.WriteLine($"{no}. {name}, Volume: {_device.Volume}");
    }
}