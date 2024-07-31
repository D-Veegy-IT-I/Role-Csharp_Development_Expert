namespace CommonCode.Documentation.TODOs
{
    internal class TODO_Actual
    {
        /// TO-DO template:
        /// TO-DO-FEATURE: [TDF001] [DONE_BUSY_PAUSED_WAITING] Implementing some_functionality as technical_concept in class_or_file_name
        /// TO-DO-BUG: [TDB001] [DONE_BUSY_PAUSED_WAITING] Debugging some_bug in some_functionality in class_or_file_name
        /// TO-DO-REFACTOR: [TDR001] [DONE_BUSY_PAUSED_WAITING] Refactoring some_old_functionality to some_new_functionality in class_or_file_name

        internal class TODO_Implementations
        {
            /* TO-DO-IMPLEMENTATIONS: [TDI001] [DONE_BUSY_WAITING] Implementing some_functionality as technical_concept in class_or_file_name */

            /// TODO: [TDI002] [WAITING] Mount a repository pattern wherever suitable (Manager class)
            /// TODO: [TDI003] [WAITING] Implement comments-based architecture into Manager class
            /// TODO: [TDI004] [WAITING] Complete PurposeIdentifier class

            internal class done
            {
                /// TODO: [TDI003] [DONE] Prospect and Implement the inferred NotImplementedException placeholder (PurposeIdentifier class)
                /// * Implemented: purpose identifier backing field with summary
                /// * Implemented: Chain backing field -> Exposing property (replacing NotImplementedException)
                /// * Noted: Comments-based architecture documentation lacks note/rule to enforce not using default init at declaration

                /// TODO: [TDI004] [DONE] Inspect and Implement the inferred businessRule.PurposeIdentifierObject.ToString() placeholder (Factory class)
                /// * Refactor "IBusinessRuleWithPurposeIdentifier" to "IBusinessRuleHavingPurposeIdentifier"
                /// * Refactor "IBusinessRuleWithEvaluationStrategy" to "IBusinessRuleHavingEvaluationStrategy"
                /// * Note: "...Having..." implies encapsulation better than "...With..." implying parallel relationship
                /// Refactor:
                /// * BusinessRuleBase<EvaluationInputType, EvaluationOutputType>.GenerateIdentifierString<IBusinessRuleHavingPurposeIdentifier> providedGetIdentifierStringLogic = (businessRule) => businessRule.PurposeIdentifierObject.ToString();
                /// * to
                /// * BusinessRuleBase<EvaluationInputType, EvaluationOutputType>.GenerateIdentifierString<IBusinessRuleHavingPurposeIdentifier> providedGetIdentifierStringLogic = (businessRule) => businessRule.PurposeIdentifierObject.PurposeIdentifier;

                /// TODO: [TDI001] [DONE] I need a 1:1 relationship between product manager and factory. (anyone can instantiate the factory, no-one-but should be able to instantiate the manager)
                /// * Research question: If anyone can create a factory through its getter-property, then how do I require that before someone can also do that for the manager?
                /// *** GPT-4 input: I have here two programming pattern implementations that im using in a C# coding library. Currently they both are singleton implementations. My wish is to allow anyone to instantiate (upon property get) the factory instance (works), but then restrict anyone but that factory instance to instantiate (upon property get) the manager instance. Essentially, I would like a manager to solely exist through the instantiation of a factory's member's call so that any manager instance cannot exist without a factory instance as these two share a unidirectional relationship over the product's lifecycle created by the factory (and then managed after by the manager).
                /// *** GTP-4 interpretation: Proposes to make Manager constructor internal, assumes both are in a separate assembly and advises sole accessibility through factory.
                /// *** GPT-4 answer issues: Isolated assemblies for two classes (very low grain of architectural components) is not sustainable; alternatively, i do not need sole access through the factory, only sole initialization.
                /// *** Solidified interpretation: Control instantiation by moving singeleton access from itself to another, anyone can use the manager freely but none but the Factory then instantiates it.
                /// *** Unresolvable Wish: Make a type Manager and Factory, and ensure that only the Factery can create a Manager. (no assemblies)
                /// *** Unresolvable Wish Reason: Two classes on the same hierarchical level can only expose their members to all, to the assembly or to none. (public, internal, private)
                /// *** Admission: A Factory and Manager are allowed to be created in unordened fashion, the relation is implied by initializing each other using their own initializing logic.
                /// *** Pretex: Manager encapsulate an exhaustive collection, this quality can only be guaranteed by adding each manufactured product as part of that process.
                /// *** Potential Issue Pretext: Someone adding a Factory.CreateProduct(...) result as argument of the Manager.Collection.Add(...) method.
                /// *** Challenge: Prevent anyone but the factory from adding something to the exhaustive collection, also provide a way to know that this mechanic exists.
                /// *** Solution: I cannot "disable" the Add extension method on a set; however, i can expose it to others as a to-read-only-transformed suitable type.
                /// *** Implemented: public static ReadOnlyCollection<IBusinessRuleHavingPurposeIdentifier> BusinessRules { get { return new List<IBusinessRuleHavingPurposeIdentifier>(_businessRules).AsReadOnly(); } }
                /// *** Realization: I am once again trying to delegate a certain call to a neighbouring class, without allowing any other types to do so.
                /// *** Admission: Factories need a them-and-manufactured-types-enclosing scope in order to make actual constructors private/internal; otherwise, anyone could subvert a Factory.
                /// *** Implementation: Made Businessrule constructor internal -> delegating initialization to Factory for anyone outside the assembly
                /// *** Refactor: Changed comments-based architecture "_others_anyone_inheritors_this" to "_others_anyone_inheritors_this_internals"
                /// *** Re-implement: Changed exhaustive set from static members to instance (singleton instance members == static members; prefer instance)
                /// *** Re-implement: Inspected the CheckIsDuplicateGenericly method -> adjusted name to intent of checking unqiqueness AND adding to collection
                /// *** Re-implement: Inspected the CheckIsDuplicateGenericly method -> any additions to the exhaustive collections now are exlcusive to the defining type
                /// *** Simplified: Inspected the PerformIsDuplicateInRepositoryCheck method -> unnecessary, duplicate checks are already in place elsewhere (code relic)
            }
        }

        internal class TODO_Debuggings
        {
            /* TO-DO-DEBUG: [TDD001] [DONE_BUSY_WAITING] Debugging some_bug in some_functionality in class_or_file_name */


        }

        internal class TODO_Refactorings
        {
            /* TO-DO-REFACTOR: [TDR001] [DONE_BUSY_WAITING] Refactoring some_old_functionality to some_new_functionality in class_or_file_name */

            /// TODO: [TDR003] [WAITING] Comments-based architecture documentation lacks note/rule to enforce not using default init at declaration

            internal class done
            {
                /// TODO: [TDR001] [DONE] Refactoring businessrule, -base, -factory and -manager to improved comments-based-architecture implementation and implied level.
                /// TODO: [TDR002] [DONE] Refactoring Identifier-string-feature chaining through businessrule, -base, -factory and -manager. (extrapolate to class, solidify logic, SOLID+ implements?)
            }
        }

        internal class TODO_Research
        {
            /* TO-DO-RESEARCH: [TDRS001] [DONE_BUSY_WAITING] Refactoring some_old_functionality to some_new_functionality in class_or_file_name */
            /// TODO: [TDRS004] [WAITING] Write a spotlight on my factory pattern findings (about how they need an enclosing scope, a "tomb")
            /// TODO: [TDRS005] [WAITING] Write a spotlight on static constructors (about how they work, and that they are private yet accessed by the compiler)

            internal class done
            {
                /// TODO: [TDRS001] [DONE] Find shortcut -> Expand regions for SELECTION only
                /// * Answer -> CTRL+ M + M while selection

                /// TODO: [TDRS002] [DONE] Add to TODO template -> Research section

                /// TODO: [TDRS003] [DONE] Add to TODO template -> "done" subsection
            }
        }
    }
}