# DECORATOR (WRAPPER) PATTERN

It's a structural pattern that uses composition to enrich existing logic without modifying the underlying class. Using
this pattern you minimize the amount of inheritance layer and give you the flexibility to change logic at runtime.

## Pattern structure

**Component**: Is the interface that have all the common logic for both concrete components and decorators.

**Concrete Component**: The Component implementation. It is these objects that will be enhanced by wrapping them with
decorators.

**Base Decorator**: Is a abstract class which takes a component interface as a constructor argument which will be the
object to be wrapped. The base decorator delegates all operations to the wrapped object.

**Concrete Decorators**:  Define extra behaviors that can be added components dynamically. Concrete decorators override
methods of the base decorator and execute their behavior either before or after calling the parent method.

**Client**: Is the one that use the decorators. Can create multiple layers of wrapped components.

_Note:_ Because both the concrete component and the decorator implement the component abstraction we are allowed to
stack up decorators on decorators.

---

## When to use Decorator pattern?

1. When you want to extend a class behaviour but the base class was declared as `sealed` (final) and cannot use
   inheritance.
2. When you want to add extra behaviour to objects at runtime.
3. When inheritance results in a exponential number of subclass (inheritance for the purpose of adding extra behaviour
   at objects).