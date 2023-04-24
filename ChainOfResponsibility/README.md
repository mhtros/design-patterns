# CHAIN OF RESPONSIBILITY PATTERN

The Chain of Responsibility pattern allows a request to be passed through a chain of handlers until it is handled or
until the end of the chain is reached. Each handler in the chain evaluates the request and either processes it or passes
it to the next handler.

## Pattern structure

---

**Handler**: Is the abstraction (abstract class or interface) that defines two methods. The Next that's is
responsible to chain the handlers together and the Handle method that does the actual work that is related to the
specific handler.

**Concrete Handlers**: The implementation of Handler. Each concrete handler processes requests by containing the actual
code for it. Upon receiving a request, the handler evaluates whether it can process it and decides whether to pass it to
the next handler or not. The handlers are self-contained and immutable, and they accept all necessary data at the time
of initialization.

**Client**: The Client has the option to compose chains dynamically.A request can be sent to any handler in the chain,
and it doesn't have to be the first one.

---

## When to use Chain of Responsibility pattern?

When request must pass through multiple handlers (pipelines) in a specific order that may change through time.