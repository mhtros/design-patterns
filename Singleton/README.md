# SINGLETON PATTERN

Singleton is a creational pattern that limits the instances of a class to one single instance (thus the name singleton).
This single instance is returned every time someone use a reference of the singleton class.

_Note_: if not used correctly singletons classes can make your code inefficient and most important untestable.

## Pattern structure

---

**Singleton**: Class that contains a static `GetInstance` method that returns the single class instance. All constructor
methods are private to ensure that only one instance can be created per run.

---

## When to use Singleton pattern?

When you need to ensure that there is only one instance available per run (e.g. Single database connection)
