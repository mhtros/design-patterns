using Builder.Products;

namespace Builder.Builders;

public class DesktopBuilder : IComputerBuilder<DesktopComputer>
{
    private DesktopComputer _desktopComputer = new();

    public IComputerBuilder<DesktopComputer> SetMotherboard(string name, decimal price)
    {
        _desktopComputer.MotherboardName = name;
        _desktopComputer.MotherboardPrice = price;
        return this;
    }

    public IComputerBuilder<DesktopComputer> SetProcessor(string name, decimal price)
    {
        _desktopComputer.ProcessorName = name;
        _desktopComputer.ProcessorPrice = price;
        return this;
    }

    public IComputerBuilder<DesktopComputer> SetGraphicCard(string name, decimal price)
    {
        _desktopComputer.GraphicCardName = name;
        _desktopComputer.GraphicCardPrice = price;
        return this;
    }

    public IComputerBuilder<DesktopComputer> SetRam(string name, decimal price)
    {
        _desktopComputer.RamName = name;
        _desktopComputer.RamPrice = price;
        return this;
    }

    public IComputerBuilder<DesktopComputer> SetPowerSupply(string name, decimal price)
    {
        _desktopComputer.PowerSupplyName = name;
        _desktopComputer.PowerSupplyPrice = price;
        return this;
    }

    public IComputerBuilder<DesktopComputer> SetSoundCard(string name, decimal price)
    {
        _desktopComputer.SoundCardName = name;
        _desktopComputer.SoundCardPrice = price;
        return this;
    }

    public IComputerBuilder<DesktopComputer> SetStorageDevice(string name, decimal price)
    {
        _desktopComputer.StorageDeviceName = name;
        _desktopComputer.StorageDevicePrice = price;
        return this;
    }

    public void Reset()
    {
        _desktopComputer = new DesktopComputer();
    }

    public DesktopComputer Build()
    {
        return _desktopComputer;
    }
}