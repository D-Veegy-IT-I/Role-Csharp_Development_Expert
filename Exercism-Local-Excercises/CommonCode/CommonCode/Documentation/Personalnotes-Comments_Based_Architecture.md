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

The explicit interface implementation syntax:

### Explicit Interface Impl. - Default Interface Members

#### Explicit Interface Implementation: Example

```csharp
public interface IHouse2D
{
     void PaintWhite();
     void PaintWallsIndividually(string[] paints);
}
public interface IHouse3D
{
     void PaintWhite();
     void PaintWallsIndividually(string[] paints);
}
public class SampleClass : IHouse2D, IHouse3D
{
 // Painting all walls is dimension-agnostic, we equalize both calls
 // Based on interface a or b, we call x and internally only do y
 public void PaintWhite()
 {
     Console.WriteLine("Any type of house is in 1 color.");
 }
 // Painting walls differs for 2D and 3D, we differentiate both calls
 // Based on interface a or b, we call x but internally do y or z
public void IHouse2D.PaintWallsIndividually(string[] paints){
    Console.WriteLine("Painted 1 wall in 1 color.");
}
public void IHouse3D.PaintWallsIndividually(string[] paints){
    Console.WriteLine("Painted 4 walls in 4 colours.");
}
// Baseline: There's 1 name for an action, but multiple versions.
}
```

#### Explicit Interface Impl. : Holistic Comprehensive Defintion

**Exploring the nature of this mechanic:**

*What is an Explicit Interface Implementation?*

An explicit interface implementation is a syntax wherein any implemented members 
of an interface by a defining type is suffixed by the name of the implied interface.

**Discussing how this mechanic changes our code:**

*How does the Explicit Interface Implementation alter an implementing class?*
Doing this removes the contractually-written piece of code from the defining type's public API and enforces anyone to solely use an upcasted (to interface) instance.

This effectively means there's a contractually-written piece of code in a surrounding type, that then only privately exists as a reference to the implemented interface.
Any wish to use that piece of code in the class then only is possible using the interface.

*How does the Explicit Interface Implementation alter an implemented interface?*
This also means that no access modifiers may be specified in the interface: 
Our contractually-written piece of code is now only usable using its interface,
thus unable to allow the usual specification thereof by accessability modifiers.

**Exploring the responsability of the mechanic:**

*Why is this an existing mechanic?*

This mechanic exists to serve the intention of primarily resolving naming conflicts.
It is meant to provide a way for types to comply with an interface, without adding those agreed-to members to its public API; it isolates us from what interfaces expect us to do.

*What comfort or Prevention does this existing mechanic offer to fellow developers?*

The implementation of Explicit Interface Implementations wherever possible allows for any developer to introduce code, even if it is accidentally named the same way.

This also allows for any developer to clearly see what interface something belongs to.

In combination with Default Interface Members, this also allows for any developer to create interfaces and their implementations that are:

- immune to naming collisions

- highly verbose about their intent and/or origin

- Default Interface Members specific: 
  
  - Do not break existing implementations when changed (dependency inversion)

**Concluding the mechanic's exploration:**

*What is the general intention of this mechanic*

This mechanic is meant to enable modular and SRP-compliant code in a way that
separates the core API from the interfaces defining its complete API.

### Collapsing and Expanding regions

- Optionally:
  
  - Go to: Tools > Options > Text Editor > C# > Advanced > Outlining 
  
  - Check: "Collapse #regions when collapsing to definitions"

- Perform "collapsing to definitions" by pressing `[CTRL + M]` and `[CTRL + O]`

- Perform "expanding to definitions" by pressing `[CTRL + M]` and `[CTRL + P]`

### My comments-based class and method structure

- This **sectional structure**:
  - assures that any developer 
    - is able to implement any coding task according to a standardized location
    - is able to implement any coding task according to a standardized intent
  - assures me that
    - any development is compliant with my holistic SRP-central coding creed
