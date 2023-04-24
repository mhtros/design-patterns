# MEMENTO PATTERN

The Memento design pattern is a behavioral pattern that provides a way to save and restore the state of an object to a
previous state, while keeping the details of the object's implementation hidden from the user.

## Pattern structure

---
**Originator**: This is the object that contains some internal state that we want to keep track and be able to restore.

**Memento**: This is the object that stores the internal state of the originator class. Once a memento object is
instantiated it cannot be changed. The memento can only be accessed by the originator that have created it.

**Caretaker**: This is the object responsible for tracking the internal state of the originator. This class can tell the
originator to revert to a previous state.

---

## When to use Memento pattern?

When you want to capture an object's current state and restore it later, while also
ensuring that direct access to the object's internal details does not violate its encapsulation.