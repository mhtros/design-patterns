# OBSERVER PATTERN

The Observer design pattern defines a publisher-subscriber dependency between objects, where a change in the state of
a publisher triggers notifications to be sent to one or more subscribers objects. This pattern allows for loose coupling
between objects and dynamic relationships between them.

## Pattern structure

---

**Publisher(Subject)**: Is the one that issue different events and notify all its subscribers.

**Subscriber(Observer)**: Is the abstraction interface that lets the concretes subscribers and the publisher to
communicate with each other, this way ensure the decouple of any concrete subscriber implementations from the publisher.

**Concrete Subscriber**: Is responsible to perform some operation depending on the publisher notification.

---

## When to use Observer pattern?

When you want to apply the publisher-subscriber paradigm.

When you want to establish dynamic relations between objects at runtime.