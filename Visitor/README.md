# VISITOR PATTERN

Visitor is a behavioral pattern that provides a way to extend the behavior(add logic) to all classes belonging in a
Inheritance hierarchy without modifying them in a dangerous way. This can be achieved by a component known as the
visitor which is responsible to traverse the whole hierarchy of related classes and by propagating a single 'visit()'
method throughout the hierarchy. The pattern allows the visitor to visit each object in the hierarchy one by one, making
it easier to work with complex object structures. This pattern use a technique called `Double Dispatch`.

## Pattern structure

---

**Visitor**: An interface that declares multiple methods (or a single with multiple overloads) where each method (or
overload) has as a parameter of a type that inherits from Element interface.

**Concrete Visitor**:  The implementation of Visitor abstraction. Each concrete visitor handles a different concrete
element type. Based on the concrete element type different implementations of the same behaviour will be execute.

**Element**: An interface that declares a single **Accept(Visitor visitor)** method that take a Visitor interface as
parameter. With this we create something called `Double Dispatch` (when a method call is dispatched not only based on
the type of the object calling the method, but also on the type of one of its arguments)

**Concrete Element**: The Element implementation. Each Concrete Element should have an acceptance method to redirect the
call to the proper visitor's method based on the current element class. All subclasses must override this method and
call the corresponding method on the visitor object.

**Client**:Client often refers to a complex object or a collection (such as a Composite tree form composite design
pattern). Interaction with these objects is achieved using a general interface, which abstracts away the implementation
details.

---

## When to use Visitor pattern?

When you need to perform an operation on every element within a type hierarchy (base class and all of its subclasses)
without modifying the actually types.

When there's a behavior that applies only to some classes in a class hierarchy, and not to the others. This helps to
keep the code organized and easy to maintain.