# FLYWEIGHT PATTERN

It's a structural pattern that lets you reduce RAM consumption by sharing IMMUTABLE common logic between objects.

## Pattern structure

**Flyweight**: Contains all the common IMMUTABLE logic that can be shared between objects.

**Flyweight Factory**: Is responsible for creating predefined flyweight objects and caching them. When asked to create
one such object it will first check the cache list, if the factory finds the object then there will be no object
instantiation and the cached object will be returned, if not, the factory will add the object into the cache list.

**Context**: Contains all the unique logic which each objects contains. When combined (by passing flyweight into context
constructor) with the flyweight objects they crete the complete object.

**Client**: The one that initialize the context object. The client is able to change the context's flyweight at runtime.

---

## When to use Flyweight pattern?

When you must handle a large amount of objects (e.g. a list with 1 million objects) that all share common logic that is
IMMUTABLE. Use this pattern only when you have RAM consumption problems and you can't solved the problem in any other
way.