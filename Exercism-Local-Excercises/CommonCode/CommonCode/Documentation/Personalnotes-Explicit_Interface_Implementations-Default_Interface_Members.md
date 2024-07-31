# Exploring various Coding concepts:

### Explicit Interface Implemenation

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

### Default Interface Members
