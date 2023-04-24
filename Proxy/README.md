# PROXY PATTERN

It's a structural pattern that enables you to control the access (mostly in order to restrict accessibility) of an
object or to provide additional
functionality before or after access it.

## Pattern structure

**Service Interface**: In order for the proxy to be used as a replacement for the service, it needs to comply with the
interface that defines the service's behavior.

**Service**: The class we aim to conceal using the proxy.

**Proxy**: The object that will act as the service replacement, managing access to it and enabling extra features like
security or caching.

---

## When to use Proxy pattern?

1. When you want to add lazy initialization in order to save system resources in a more centralized manner. (**virtual
   proxy**)
2. When you want to restrict access only to specific clients. (**protection proxy**)
3. When you want to call a remote service but you don't want the clients to deal with the network details. (**remote
   proxy**)