namespace Observer.Models;

public class Mobile
{
    public Mobile(string model, Manufacturer manufacturer, decimal price)
    {
        Model = model;
        Manufacturer = manufacturer;
        Price = price;
    }

    public string Model { get; set; }
    public Manufacturer Manufacturer { get; set; }
    public decimal Price { get; set; }
}