# Exploring various Coding concepts:

## Rules

1) Use explicit interface implementations wherever possible [Link to mechanic file](./Personalnotes-Explicit_Interface_Implementations-Default_Interface_Members.md)
   
   - SOC (Separation of Concerns) compliance:
     
     - Maintain separation between core class API and additional interface API
     
     - Explicit interfaces do not inherit -> keep code where it is used
     
     - Explicit interfaces are immume to naming conflicts

2- Use Default interface members wherever possible

- DIP (Dependency Inversion Protocol) compliance:
  
  - Whenever one interface relies upon its implementation elsewhere,
    any concrete change to the interface equates to change for dependants
  
  - Whenever one interface is relied upon for default interface members,
    any concrete change to the interface equates to no change for dependants

3- Avoid using automatic properties wherever possible

- SRP (Single Responsability Protocol) compliance:
  
  - Both the static constructor and any instance constructors have respective
    responsabilities over the initialization of any type static or instance states
  
  - Automatic properties hide intialization logic that belongs to constuctors
  
  - Any concrete changes to initialization are centralized to constructors,
    unless various automatic properties inhibit this architectural tenet

4- Initialize any declarations as default, thus separating declaration and assignment

   1- SRP and SOC

      - Use class-level and method-level constructs to separate and delegate
        the acts of declaring a state, then (re)initializing that state appropriately
    
      - Enables anyone to locate any development, debugging and testing tasks
    
    
    
    
    
    #region Design Considerations
    /* List:
     * Pure functions -> Solely returns a value, no side effects or scope breaches
     * Insulate code -> Any member's scope should be limited to their needs solely
     * Mark-up intent -> There's orchestration, defining, process, conclude etc.
     * Data Grouping -> They exist, flow and process the same? -> group together!
     * Reusability -> Something useable for subtypes? Enable overriding.
     * Testing -> Every standalone function with prefix "process" -> test.
    * SOLID
        * Single Responsibility Principle: Every module should have only one reason to change.
        * Open/closed Principle: A software module is open for extension and closed for modification
        * Liskov Substitution Principle: A derived module must be substitutable by its base one
        * Interface Segregation Principle: Clients should not be forced to implement what they don't need.
        * Dependency Inversion Principle: High-lvl shouldn't depend on low-lvl, and both on abstractions.
    
    * DRY, DIE and KISS. Dont repeat yourself, Duplication is evil and Keep it simple stupid.
    * Code verbosity: The best code can speak for itself using variable names, structure and flow.
    * DI: Any dependency that isn't a constant, should be placed where it could be injected.
    */
    #endregion
