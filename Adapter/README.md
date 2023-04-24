# ADAPTER PATTERN

Adapter is a structural pattern that allows communication between objects that want to collaborate with each other but
they don't have a common interface or have different data types (e.g. one class work with json and another class work
with xml). There is two different approaches to implement the adapter pattern, one is through composition and the other
through inheritance.

## Pattern structure

**Adapter**: Is the abstraction (abstract class or interface) that describes how service class and client class
can communicate.

**Concrete Adapter**: The Implementation of the Adapter abstraction.

**Service**: A third party class (or ours) that we cannot change but we want to use it.

**Client**: A class that belong to our code base (or a different third party library) and must use the logic of a
service class (look above) but we don't or can't change it in order to have compatible APIs.

We pass the adapter class as a constructor parameter either on client class or service class and implement the methods
that
will use internally the corresponding adapter methods. If you can't change neither client or service classes then create
a new Adapter (wrapper) class.

_Note:_ The adapter pattern can be used bidirectional, meaning that we can create adapt methods for both service and
client classes. e.g. A service class contains temperature calculation methods that have celsius metric as inputs and a
client class that contains relative methods that accept fahrenheit as metric. The methods from both classes can be
combined to create a new more robust temperature calculation process but in order to be able to communicate with each
other we must create a bidirectional adapter. To achieve bi-directionality the adapter class will have to implement two
methods `double FahrenheitToCelsius(double fahrenheitTem)`, `doule CelsiusToFahrenheit(double celsiusTem)`

---

## When to use Adapter pattern?

When you want to combine classes that have incompatible APIs but you cannot change their code either because the class
comes from a third party library or because there's a lot of classes that depends on it and it's extremely dangerous to
be touched.