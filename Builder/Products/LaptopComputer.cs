using System.Text;

namespace Builder.Products;

public class LaptopComputer : Computer
{
    public override decimal TotalPrice =>
        MotherboardPrice + ProcessorPrice + RamPrice + StorageDevicePrice + GraphicCardPrice;

    public string? GraphicCardName { get; set; }
    public decimal GraphicCardPrice { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        var baseStr = base.ToString();
        sb.Append(baseStr);

        if (GraphicCardName is not null)
            sb.AppendLine($"{nameof(GraphicCardName)}: {GraphicCardName} ({GraphicCardPrice:N})");

        return sb.ToString();
    }
}