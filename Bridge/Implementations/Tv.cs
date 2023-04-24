namespace Bridge.Implementations;

public class Tv : Device
{
    public override Dictionary<int, string> Channels { get; set; } = new()
    {
        {1, "OPEN"},
        {2, "ERT 1"},
        {3, "ERT 2"},
        {4, "ERT 3"},
        {5, "ANT1"},
        {6, "ALPHA"},
        {7, "STAR"},
        {8, "SKAI"},
        {9, "MEGA"}
    };

    public override int MaxVolume { get; set; } = 5;
}