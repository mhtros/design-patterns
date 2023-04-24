# COMMAND PATTERN

The command pattern is a behavioral design pattern that converts a method call into an object. That gives you the
ability to pass method objects (also known as requests, commands) into different objects and make possible the
following:

- Commands execution delay.
- Execute commands remotely.
- Commands Batch execution.
- Rollback commands executions.

## Pattern structure

---

**Invoker**: The invoker or Sender class is in charge of initiating requests, and it must contain a field
or a list to store the command object's reference. The sender triggers the command instead of directly sending the
request to the receiver. The sender isn't responsible for creating the command object; it usually receives a
pre-existing command from the client via the constructor.

_Note: The undo part most of the times are handled by the `Invoker` class._

**Command**: A plain interface with a single method `void Execute()`. Optionally you can declare and the
method `void Undo()` which is the reverse of Execute.

**Concrete Command**: There can be multiple implementations of commands. The primary role of a concrete command is not
to execute the task by itself, but rather to forward the call to the relevant business logic object. To simplify the
code, these classes can be combined. The concrete command can declare the parameters necessary to execute a method on
the receiving object as fields. To make command objects immutable, these fields can only be initialized via the
constructor.

**Receiver**: The Receiver class contains the business logic. Typically, commands are responsible to forward the request
to the receiver, whereas the receiver executes the actual task.



---

## When to use Command pattern?

1. When you want your objects to use operations from different business layers but you also want to adhere to separation
   of concern principle.
2. When you want to add rollback functionality to operations.
