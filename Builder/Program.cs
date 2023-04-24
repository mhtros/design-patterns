using Builder.Builders;
using Builder.Directors;

var desktopBuilder = new DesktopBuilder();
var laptopBuilder = new LaptopBuilder();

// Create object only using the concrete builder

var customLaptop = desktopBuilder
    .SetMotherboard("Custom motherboard", 250m)
    .SetProcessor("Custom processor", 350m)
    .SetRam("Custom Ram", 90m)
    .SetPowerSupply("Custom power supply", 70m)
    .SetStorageDevice("Custom storage device", 50m)
    .Build();

Console.WriteLine(customLaptop);
Console.WriteLine("-----------");

// Or use a director class to generate a preconfigured computer
var composer = new GamingComputerComposer();

var gamingDesktop = composer.CreateGamingDesktopComputer(desktopBuilder);
var gamingLaptop = composer.CreateGamingLaptopComputer(laptopBuilder);

Console.WriteLine(gamingDesktop);
Console.WriteLine("-----------");
Console.WriteLine(gamingLaptop);