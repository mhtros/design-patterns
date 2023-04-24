# STATE PATTERN

State pattern it's a behavioral design pattern that enables an object to modify its behavior when its internal state
changes. This pattern is analogous to finite-state machines, and it can be viewed as a strategy pattern that utilizes
method invocations defined in the pattern's interface to switch strategies.

## Pattern structure

---

**Context**: The object that changes it's behaviour based on the current state. In order to separate all the state
related functionality it keep a private property that represents the current state and delegates all state related work
to that class. The context class is able to change the type of the current state at runtime as long as the type
implements the state interface.

**State**: Is the abstraction interface that all the state concrete class must adhere to, so it's important that the
methods defined in this interface have meaning for every available state.

**Concrete State**: The implementation of the State interface. It's recommended to extract all boilerplate code that all
state objects use into separates abstract class. Also in some scenarios(because this creates a bidirectional relation
between context and states) is advised that the states object have a reference of the context object.

---

## When to use State pattern?

If you have an object that behaves differently based on its current state, and there are a lot of possible states with
code that changes often.

If you find a class with a lot of conditionals that change how the class behaves depending on the values of its fields,
then you can use the pattern to clean up the code.