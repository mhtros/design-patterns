# ITERATOR PATTERN

The Iterator pattern is a behavioral design pattern that enables you to navigate through a collection's elements without
revealing its internal structure.

## Pattern structure

---

**Iterator**: Is an interface that defines all the necessary actions need it for navigate through a collection. This
includes tasks such s obtaining the next element, accessing the current position, restarting the iteration.

**Concrete Iterator**: Is the implementation of the iterator. Concrete iterator must track the traversal progress on its
own to allow several other independent iterators to be able to traverse the same collection.

**Collection**: Is an interface that must implement one or more methods that return iterator type objects.

**Concrete Collection**: Concrete Collections provide new instances of a specific Concrete Iterator class. This class is
also responsible for the rest of the collection implementation code.

---

## When to use Iterator pattern?

If you need to separate the algorithm that iterate the collection from the underline collection structure.