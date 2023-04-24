# MEDIATOR PATTERN

The Mediator design pattern is a useful tool for managing relationships between objects that may otherwise become
chaotic and difficult to maintain. By restricting direct communication between these objects and instead requiring them
to work together through a mediator object, the pattern promotes better collaboration and organization.

## Pattern structure

---

**Mediator**: The interface of the Mediator outlines the way that components communicate with each other, which
generally involves a single method for sending notifications. Components can send relevant information as parameters to
this method, but it is important that the method is designed in such a way that there is no direct relationship between
the component receiving the information and the class of the component that sent the information.

**Concrete Mediator**: The mediator acts as a middleman, keeping track of how different parts of a system communicate
with each other. It often knows about all the different parts and may even be responsible for creating or destroying
them as needed. This helps keep things organized and makes it easier to make changes to the system later on.

**Components**: Classes that contain business logic and one dependency injection property of the mediator interface. The
component doesn't know the exact class of the mediator, so you can use the component in other programs by connecting it
to a different mediator. This makes it easier to reuse the component in different applications without having to make
significant changes to its underlying code.

Components should not communicate with each other directly. They have fist to notify the mediator class with the
appropriate message. The mediator then decides what actions to take based on the message it receives.

---

## When to use Mediator pattern?

When you have many components (classes) that all communicate with each other, resulting in complex
relationships-dependencies between them.