using Flyweight.Contexts;
using Flyweight.Factories;
using Flyweight.Flyweights;

var factory = new PricingPlanFactory();

factory.Add("basePlan", new PricingPlan(1.2m, 1.5m, 0.10m));
factory.Add("premiumPlan", new PricingPlan(0.8m, 1m, 0.5m));

var basePlan = factory.Get("basePlan");
var premiumPlan = factory.Get("premiumPlan");

var customer1 = new Customer(basePlan) {DataConsumption = 1000, CallMinutes = 20, TextNumber = 100};
var customer2 = new Customer(basePlan) {DataConsumption = 500, CallMinutes = 60, TextNumber = 45};

//both the customer1 and customer2 use the same plan object.
Console.WriteLine($"{customer1.CalculateCallCost():N}");
Console.WriteLine($"{customer2.CalculateCallCost():N}");

// change customer1 plan at runtime.
customer1.ChangePricingPlan(premiumPlan);
Console.WriteLine($"{customer1.CalculateCallCost():N}");