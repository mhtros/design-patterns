# ABSTRACT FACTORY PATTERN

Abstract factory is a creational pattern that relies on composition. It's a somewhat of an updated from of Factory
method pattern.

When many related factory methods accumulate over time we can combine them all in a single Factory class.

## Pattern structure

---

**Abstract Products**: Is the abstraction (abstract class or interface) that
defines all the related classes that belong to a specific family.

**Concrete Products**: The Implementation of the abstract products. You MUST implement all abstractions foreach
family.

**Abstract Factory**: Is the abstraction (abstract class or interface) that
declares create methods for all abstract products.

**Concrete Factory**: The Implementation of abstract factories. Each concrete factory is corresponding to a single class
family.

_Note_: In order for this pattern to work all the concrete factories HAVE to return the abstraction which are based on
instead the concrete class.

**Client**: The client is the object that uses the abstract factory class (it's commonly practice to pass the Abstract
Factory class as argument in the client constructor).

_Note_: The selection of the concrete factory class type is typically selected when the application is starting and
there after is passed on clients constructors using dependency injection.

---

## When to use Abstract Factory pattern?

When you need to work with multiply families of related classes but you don't want to couple the code that using those
classes with their concrete implementation. That way you don't have to know the concrete type at compile time and the
probability that there are two object instances of a different class family is zero (as long as you work with the
abstractions-interfaces).