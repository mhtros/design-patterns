# STRATEGY PATTERN

The strategy pattern is a behavioural pattern that gives you the ability to group similar algorithms into their own
classes, making it easier to swap them in and out at runtime as needed. This makes your code more flexible and
adaptable, as you can easily switch between different strategies without having to change the class that uses them.

## Pattern structure

---

**Context**: Keeps track of a particular strategy and communicates with it exclusively through the strategy interface.
This ensures that the Context class can work with different strategies without having to know the details of each one,
making it more flexible and adaptable to change.

**Strategy**: The strategy interface is shared among all the concrete strategies, defining a method that the Context
class calls to execute a strategy.

**Concrete Strategy**: The implementation of the Strategy abstraction.

**Client**: Is the class that tells Context which strategy to execute every time.

---

## When to use Strategy pattern?

When you want to execute various implementations of a single algorithm at runtime.

When you have multiple classes that are similar, but vary in their implementation of a particular behavior.

When you have a big switch or if else statements that switches between different versions of a single algorithm.

When you want to separate the core business logic of a class from the implementation details of algorithms that may not
be crucial to that logic.