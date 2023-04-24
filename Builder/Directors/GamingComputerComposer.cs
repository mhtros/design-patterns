using Builder.Builders;
using Builder.Products;

namespace Builder.Directors;

public class GamingComputerComposer
{
    public DesktopComputer CreateGamingDesktopComputer(DesktopBuilder builder)
    {
        const string processor = "Intel Core i9-9900KS - Core i9 9th Gen Coffee Lake 8-Core 4.0 GHz";
        builder.SetProcessor(processor, 2610.99m);

        const string board = "ASUS ROG Maximus Z690 Extreme Glacial (WiFi 6E) LGA 1700(Intel® 12th&13th Gen)";
        builder.SetMotherboard(board, 6278.99m);

        const string graphics = "Lenovo NVIDIA Tesla T4 Graphic Card 16 GB Passive Cooler PC";
        builder.SetGraphicCard(graphics, 5369.35m);

        const string ram = "G.SKILL Trident Z Royal Elite Series 128GB";
        builder.SetPowerSupply(ram, 1399.99m);

        const string power = "ThermalTake ToughPower iRGB Plus 1250W Digital SLI/CrossFire Ready Continuous Power";
        builder.SetPowerSupply(power, 829.99m);

        const string ssd = "HPE 3.84 TB Solid State Drive 2.5\" Internal SATA SATA/600 Mixed Use Server Device";
        builder.SetStorageDevice(ssd, 5628.57m);

        const string sound = "Yamaha MY16AT";
        builder.SetSoundCard(sound, 777m);

        return builder.Build();
    }

    public LaptopComputer CreateGamingLaptopComputer(LaptopBuilder builder)
    {
        const string processor = "Intel® Core™ i9-12900H Processor 24M Cache, up to 5.00 GHz";
        builder.SetProcessor(processor, 617m);

        const string board = "213015-1 448.0NQ13.0011 for Lenovo ThinkPad P1 Gen 5";
        builder.SetMotherboard(board, 1250m);

        const string graphics = "GeForce RTX 3080 Ti 12G";
        builder.SetGraphicCard(graphics, 957.18m);

        const string ssd = "1 TB SSD M.2 2280 PCIe TLC Opal";
        builder.SetStorageDevice(ssd, 200m);

        return builder.Build();
    }
}