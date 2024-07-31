# Exploring various Coding concepts:

## Interfaces - Abstract Classes:

#### Interfaces: Holistic Comprehensive Definition:

Interfaces define a contract for behaviour without implementing any itself.
**Note**: This intent has been enriched by the C#8.0 Default Interface Members feature.
(Interfaces can now have an independent state-full default member implementation)

The main characteristics include:

- *Behavioural Contract*: An interface speficies "what" a class can do, not "how"

- *No State*: Interfaces cannot maintain state

- *Interface Polymorphism*: Interfaces enable a form of polymorphism where objects of different classes can be treated as objects of the interface type, provided those classes implement the interface. This is useful for classes that fall into the same "role" or "capability" but otherwise do not share a common ancestor.

- *Multiple Implementations*: Classes in C# can implement multiple interfaces; however, classes in C# can only inherit from one other class.

#### Abstract classes: Holistic Comprehensive Definition:

Abstract classes define a partial implementation of a subclass while leaving some methods to be implemented by subclasses. They blend the "what" and "how".

The main characteristics include:

- *Partial Implementation*: They can provide a mix of fully implemented (concrete) methods and abstract methods. This enables them to define both the "what" (through abstract methods) and the "how" (through concrete methods)

- *State Holding*: Unlike interfaces, abstract classes can hold state

- *Inheritance Restriction*: Classes may only inherit from one abstract class due to C#'s single inheritance model, which means abstract classes are a good choice when you want to enforce certain fundamental behaviours and structural elements across a series of derived classes.

- *Control Over Method Implementation*: Abstract classes can define methods as 'virtual' (allowing overrides), 'abstract' (requiring overrides), or neither (disallowing overrides), giving the base class control over the behaviour's modifiability.

#### Interfaces and Abstract classes: Parallel Insulated Definition:

**Interfaces** are about templating a contract **about** family-agnostic behaviours.
**Abstract classes** are about templating a base **for** family-bound classes.

#### Interfaces and Abstract classes: Codependent Definition:

Interfaces are extensions for any types that benefit from grouping by behaviour, while
abstract classes are foundations of common function and state for only related types.
