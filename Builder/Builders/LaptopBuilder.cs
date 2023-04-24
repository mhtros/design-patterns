using Builder.Products;

namespace Builder.Builders;

public class LaptopBuilder : IComputerBuilder<LaptopComputer>
{
    private LaptopComputer _laptopComputer = new();

    public IComputerBuilder<LaptopComputer> SetMotherboard(string name, decimal price)
    {
        _laptopComputer.MotherboardName = name;
        _laptopComputer.MotherboardPrice = price;
        return this;
    }

    public IComputerBuilder<LaptopComputer> SetProcessor(string name, decimal price)
    {
        _laptopComputer.ProcessorName = name;
        _laptopComputer.ProcessorPrice = price;
        return this;
    }

    public IComputerBuilder<LaptopComputer> SetRam(string name, decimal price)
    {
        _laptopComputer.RamName = name;
        _laptopComputer.RamPrice = price;
        return this;
    }

    public IComputerBuilder<LaptopComputer> SetStorageDevice(string name, decimal price)
    {
        _laptopComputer.StorageDeviceName = name;
        _laptopComputer.StorageDevicePrice = price;
        return this;
    }

    public IComputerBuilder<LaptopComputer> SetGraphicCard(string name, decimal price)
    {
        _laptopComputer.GraphicCardName = name;
        _laptopComputer.GraphicCardPrice = price;
        return this;
    }

    public IComputerBuilder<LaptopComputer> SetPowerSupply(string name, decimal price)
    {
        return this;
    }

    public IComputerBuilder<LaptopComputer> SetSoundCard(string name, decimal price)
    {
        return this;
    }

    public void Reset()
    {
        _laptopComputer = new LaptopComputer();
    }

    public LaptopComputer Build()
    {
        return _laptopComputer;
    }
}