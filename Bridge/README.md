# BRIDGE PATTERN

It's a structural pattern that uses composition to break multiple inheritance dependency (orthogonal)dimensions in a
single class in order to separate abstraction from implementation which can be developed independently of each other.

## Pattern structure

There is not a straightforward way to describe with words (at least for me) what role each component have, because the
definition get entangled with object oriented terms. You might find more helpful the diagrams on the "**When to
use Bridge pattern?**" section.

**Client**: The client is working most of the times only with the abstraction and is responsible to link the abstraction
with the implementation.

**Abstraction**: The abstraction is responsible only to provide a high-level API for the client to use. The
implementation component is the one to actually do the internal logic implementation.

**Implementation**: Even if we refer this component as implementation it is actually an abstraction (abstract class or
interface) and contains the API which will be used by the abstraction. The abstraction can communicate with the
implementation only using the API provided by this component. Each API on the client is correspond to one or a
combination of implementation API.

**Concrete Implementations**: The Implementations of the Implementation (and they say design patterns are easy to
understand... go figure).

_Note:_ Bridge and adapter have identical designs, the key difference between the two lies on the context.
For example bridge is used at the designed level before any code was written to enable independently development of each
component. On the other hand the adapter pattern is used when the code is already written and it's difficult or
impossible to change.

---

## When to use Bridge pattern?

When you have a class that extends two independent orthogonal dimensions and the combination of those dimensions results
in a cartesian product number of subclasses.

For example when inheritance create the following structure:

```
         _ A _
        /     \
      Ax       Ay
     / \       / \
    Ax1 Ax2   Ay1 Ay2
```

Refactor using composition to:

```
    A            N
  /   \         / \
Ax(N) Ay(N)    1   2
```