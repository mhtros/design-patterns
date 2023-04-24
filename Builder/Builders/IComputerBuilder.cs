using Builder.Products;

namespace Builder.Builders;

public interface IComputerBuilder<out T> where T : Computer
{
    public IComputerBuilder<T> SetMotherboard(string name, decimal price);
    public IComputerBuilder<T> SetProcessor(string name, decimal price);
    public IComputerBuilder<T> SetGraphicCard(string name, decimal price);
    public IComputerBuilder<T> SetRam(string name, decimal price);
    public IComputerBuilder<T> SetPowerSupply(string name, decimal price);
    public IComputerBuilder<T> SetSoundCard(string name, decimal price);
    public IComputerBuilder<T> SetStorageDevice(string name, decimal price);
    public T Build();
    public void Reset();
}