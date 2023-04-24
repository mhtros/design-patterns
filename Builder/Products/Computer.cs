using System.Text;

namespace Builder.Products;

public abstract class Computer
{
    public abstract decimal TotalPrice { get; }

    public string? MotherboardName { get; set; }

    public decimal MotherboardPrice { get; set; }

    public string? ProcessorName { get; set; }

    public decimal ProcessorPrice { get; set; }

    public string? RamName { get; set; }

    public decimal RamPrice { get; set; }

    public string? StorageDeviceName { get; set; }

    public decimal StorageDevicePrice { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Total: {TotalPrice}");

        if (MotherboardName is not null)
            sb.AppendLine($"{nameof(MotherboardName)}: {MotherboardName} ({MotherboardPrice:N})");

        if (ProcessorName is not null) sb.AppendLine($"{nameof(ProcessorName)}: {ProcessorName} ({ProcessorPrice:N})");

        if (RamName is not null) sb.AppendLine($"{nameof(RamName)}: {RamName} ({RamPrice:N})");

        if (StorageDeviceName is not null)
            sb.AppendLine($"{nameof(StorageDeviceName)}: {StorageDeviceName} ({StorageDevicePrice:N})");

        return sb.ToString();
    }
}