# TEMPLATE METHOD PATTERN

Template Method is a behavioural design pattern that outlines the basic structural steps of an algorithm in a
superclass. Subclasses can modify specific steps without altering the overall structure.

## Pattern structure

---

**Abstract Class**: The Abstract Class includes individual methods that represent all the steps of the algorithm.
Additionally, it declares a TemplateMethod that internally invokes these step methods. Each step function can be
declared abstract or provide a base implementation.

**Concrete Class**: Concrete Classes can override one, many or all specific steps within the algorithm, but it cannot
change the template method that calls those steps.

---

## When to use Template method pattern?

when clients need to modify specific steps within an algorithm, without altering the entire algorithm or its structure.

when there are multiple classes with similar algorithms that only differ slightly.