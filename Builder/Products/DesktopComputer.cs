using System.Text;

namespace Builder.Products;

public class DesktopComputer : Computer
{
    public override decimal TotalPrice => MotherboardPrice + ProcessorPrice + GraphicCardPrice + RamPrice +
                                          PowerSupplyPrice + StorageDevicePrice + SoundCardPrice;

    public string? GraphicCardName { get; set; }
    public decimal GraphicCardPrice { get; set; }

    public string? PowerSupplyName { get; set; }
    public decimal PowerSupplyPrice { get; set; }

    public string? SoundCardName { get; set; }
    public decimal SoundCardPrice { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        var baseStr = base.ToString();
        sb.Append(baseStr);

        if (GraphicCardName is not null)
            sb.AppendLine($"{nameof(GraphicCardName)}: {GraphicCardName} ({GraphicCardPrice:N})");

        if (PowerSupplyName is not null)
            sb.AppendLine($"{nameof(PowerSupplyName)}: {PowerSupplyName} ({PowerSupplyPrice:N})");

        if (SoundCardName is not null) sb.AppendLine($"{nameof(SoundCardName)}: {SoundCardName} ({SoundCardPrice:N})");

        return sb.ToString();
    }
}