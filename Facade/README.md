# FACADE PATTERN

It's a structural pattern that makes a complex class subsystem easier to use by abstracting all the unnecessary
complexity behind well defined interfaces.

## Pattern structure

**Facade**: Is the abstraction (abstract class or interface) that decouples the complex class subsystem from our
implementation and make it easier to use by providing simplified apis that abstracts all the redundant complexity.

_Note: A Facade can be used to simplify another facade interface._

**Concrete Facade**: The implementation of the facade interface.

**Complex Class Subsystem**: The Complex Subsystem is made up of many different parts. To use them effectively, you need
to have a good understanding of how the subsystem works, including the right way to set up each object and the kind of
information they need to function correctly.

**Client**: The client only works with the facade and is unaware of the complex class subsystem existence.

---

## When to use Facade pattern?

1. When you work with a complex class subsystem (made by you or a 3rd party library) and you want it to un-couple it
   form you code or hide the unnecessary complexity.

2. When you have a complex class subsystem and you want to divided into different sub-layers. 