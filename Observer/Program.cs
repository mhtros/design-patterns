using Observer;
using Observer.Models;
using Observer.Publisher;
using Observer.Subscribers;

var superStore = new MobileStore();

var buyer1 = new ExpensiveBuyer();
buyer1.Subscribe(superStore);

Console.WriteLine("--- New Release ---");
superStore.NewMobileRelease(new Mobile("Galaxy A13 2022", Manufacturer.Samsung, 185.5m));

var buyer2 = new BrokeStudent();
buyer2.Subscribe(superStore);

Console.WriteLine("--- New Release ---");
superStore.NewMobileRelease(new Mobile("13 Pro 5G Dual SIM (12GB/256GB)", Manufacturer.Xiaomi, 1398.89m));

var buyer3 = new AppleFunBoy();
buyer3.Subscribe(superStore);

Console.WriteLine("--- New Release ---");
superStore.NewMobileRelease(new Mobile("Galaxy A03 Core Dual SIM (2GB/32GB)", Manufacturer.Samsung, 93.6m));

buyer2.Unsubscribe();

Console.WriteLine("--- New Release ---");
superStore.NewMobileRelease(new Mobile("iPhone 14 Pro Max 5G (6GB/1TB)", Manufacturer.Apple, 2128.89m));

Console.WriteLine("--- Bankruptcy ---");
superStore.Bankruptcy();