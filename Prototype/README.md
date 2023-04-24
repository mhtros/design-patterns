# PROTOTYPE PATTERN

Prototype is a creational pattern that provides a common interface to clone class instances without depending on their
concrete type.

## Pattern structure

---

**Prototype**: Is the abstraction (abstract class or interface) that define a simple clone method.

**Concrete Prototype**: The Implementation of the abstract prototype.

_Note_: We can create a class (Prototype registry) that provides an easy way to access frequently-used prototypes.
This can be achieved by declaring a private list of prototypes and provide simple methods to retrieve or add prototype
objects.

---

## When to use Prototype pattern?

When you need to work with multiply families of related classes but you don't want to couple the code that using those
classes with their concrete implementation. That way you don't have to know the concrete type at compile time and the
probability that there are two object instances of a different class family is zero (as long as you work with the
abstractions-interfaces).