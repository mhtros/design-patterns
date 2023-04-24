# COMPOSITE PATTERN

It's a structural pattern that relies on inheritance and is used to make a group(e.g. lists, arrays) of
objects to be treated the same way as the single object.

## Pattern structure

**Component**: Is the abstraction (abstract class or interface) that defines all the common behaviour that both the
single object and the group of objects share. The API defined in this abstraction must behave exactly the same
regardless the type of the object (Leaf/Composite).

**Leaf**: A single object that inherits/implements from the component.

**Composite**: A group(e.g. lists, table) that contains Leaf objects. The composite only works with the Component
abstraction and is ignorant of any concrete implementation.

---

## When to use Composite pattern?

When your model forms a **tree like hierarchy** which is consists of objects or groups(e.g. lists, arrays) of those
objects and you want both to be treated the same way (in most scenarios).