# FACTORY METHOD PATTERN

Factory Method is a creational patterned that relies on inheritance and provides an interface for creating objects.

## Pattern structure

---

**Creator**: Is the abstraction (abstract class or interface) that
declares a method which is used to create concrete products.

_Note_: Despite its name, the main responsibility of creators is
NOT the creation of products but rather some core logic that is
related to products for example a file generator class may have logic for
object serialization (xml, json) but the main purpose of the
class is to generate files.

**Product**: Is the abstraction (abstract class or interface) that
declares all the common logic shared by all object made by
the creator.

_Note_: Objects created by the CREATOR are called products.

**Concrete Creator**: The Implementation of the creator abstraction.

**Concrete Product**: The Implementation of the product abstraction.

---

**Client**: The client is the object that uses the factory method
(Its not consider part of the pattern structure).

## When to use Factory Method pattern?

1. When you don't know from the start (compile time)
   the exact object type and the dependencies that it needs.

2. When you want to allow the users of your library/framework

3. When you want to reuse existing object instead of building
   new ones each time.