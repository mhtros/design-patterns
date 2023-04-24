namespace Bridge.Implementations;

public class Radio : Device
{
    public override Dictionary<int, string> Channels { get; set; } = new()
    {
        {1, "SOK FM"},
        {2, "MAD RADIO"},
        {3, "ROCK FM"},
        {4, "ENERGY"}
    };

    public override int MaxVolume { get; set; } = 5;
}