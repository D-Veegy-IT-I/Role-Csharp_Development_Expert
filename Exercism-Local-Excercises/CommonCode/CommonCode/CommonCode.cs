using CommonCode.BusinessRules;
using CommonCode.Interfaces;
using CommonCode.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCode
{
    public class CommonCode
    {
        /// <summary> Type guarantee for having a Business rule Evaluation strategy and Mounting point for ISP interfaces.</summary>
        public interface IBusinessRule<EvaluationInputType, EvaluationOutputType> : IBusinessRuleHavingPurposeIdentifier, IBusinessRuleHavingEvaluationStrategy<EvaluationInputType, EvaluationOutputType>
        {

        }
        /// <summary> Interface-intent: Business-rule-members that enable intent identification/verbosity by delegate-generation, then property-exposition.</summary>
        public interface IBusinessRuleHavingPurposeIdentifier
        {
            IPurposeIdentifier PurposeIdentifierObject { get; }
        }
        public interface IPurposeIdentifier
        {
            string PurposeIdentifier { get; }
            delegate string GeneratePurposeIdentifier<GeneratorInputType>();
        }
        public interface IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType>
        {
            EvaluationOutputType ExecuteStrategy(EvaluationInputType evaluationInput);
        }
        /// <summary> Interface-intent: Business-rule-members that enable strategy-pattern implementations with a generic signature.</summary>
        public interface IBusinessRuleHavingEvaluationStrategy<EvaluationInputType, EvaluationOutputType>
        {
            IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType> EvaluationStrategy { get; }
            EvaluationOutputType ExecuteStrategyLogicWrapper(EvaluationInputType evaluationInput);
        }


        /// <summary> [Public] class for [business rule] as [business] entity; this encapsulates [any rule (validation logic) a process designates as a business rule].</summary>
        public class BusinessRule<EvaluationInputType, EvaluationOutputType> : BusinessRuleBase<EvaluationInputType, EvaluationOutputType>
        {
            /// Explore the Documentation folder for: todo's, rules, concepts, notes and standards.

            #region Backing field members
            /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>

            // [STATIC BACKING FIELD MEMBERS]
            /// <summary> [Private] static backing field for [business rule manager] internal state; Enabling [this] to [read a business rule manager instance].</summary>
            private static BusinessRuleManager _businessRuleManagerInstance;

            // [INSTANCE BACKING FIELD MEMBERS]


            #endregion

            #region Constructors
            #region Static-data constructor member
            /// <structure-section> Encapsulation of all foundational static member initializations via this default static constructor.</structure-section>

            // [STATIC CONSTRUCTOR MEMBER]
            /// <summary> default static constructor handling all static member initializations.</summary>
            static BusinessRule()
            {
                // [Initialize backing fields: only initialization, no declaration or processing!]
                _businessRuleManagerInstance = BusinessRuleManager.BusinessRuleManagerInstance;
            }

            #endregion

            #region Instance-data constructor members
            /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>

            // [INSTANCE CONSTRUCTOR MEMBERS]
            /// <summary> argumented instance constructor handling (collectively) all instance member initializations.</summary>
            internal BusinessRule(IPurposeIdentifier purposeIdentifierObject, IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType> evaluationStrategy) : base(purposeIdentifierObject, evaluationStrategy)
            {
                // [Initialize backing fields: only initialization, no declaration or processing!]
            }

            #endregion
            #endregion

            #region General property members
            /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>

            // [STATIC GENERAL PROPERTY MEMBERS]

            // [INSTANCE GENERAL PROPERTY MEMBERS]
            /* Insulated into Baseclass*/ /*public override string IdentifierString { get { return _identifierString; } protected set { _identifierString = value; } }*/
            /* Insulated into Baseclass*/ /*public override IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType> EvaluationStrategy { get { return _evaluationStrategy; } protected set { _evaluationStrategy = value; } }*/

            #endregion

            #region Implementing business logic
            #region Business Logic members
            /// <structure-section> Centralization of all core business-logic-encapsulating member; a sole address for any related development.</structure-section>

            // [STATIC MAIN BUSINESS-LOGIC MEMBERS]

            // [INSTANCE MAIN BUSINESS-LOGIC MEMBERS]

            #endregion

            #region Utility members
            /// <structure-section> Centralization of all core utility-therefore-business-logic-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC UTILITY MEMBERS]

            // [INSTANCE UTILITY MEMBERS]

            #endregion

            #region Delegate members
            /// <code-structure-section> Centralization of all foundational logic-delegating signatures; a sole address for any delegate-related development.</structure-section>

            // [ DELEGATE MEMBERS]

            #endregion
            #endregion

            #region Practical nice to have functionality
            #region Exception Handling members
            /// <structure-section> Centralization of all core exception-handling-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXCEPTION-HANDLING MEMBERS]

            // [INSTANCE EXCEPTION-HANDLING MEMBERS]

            #endregion

            #region Business rule and Validation members
            /// <structure-section> Centralization of all core business-rule/validation-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC BUSINESS-RULE/VALIDATION MEMBERS]

            // [INSTANCE BUSINESS-RULE/VALIDATION MEMBERS]

            #endregion
            #endregion

            #region Technical nice to have functionality
            #region Logging members
            /// <structure-section> Centralization of all core logging-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC LOGGING MEMBERS]

            // [INSTANCE LOGGING MEMBERS]

            #endregion
            #endregion

            #region Probably not in scope
            #region Presentation Layer members
            /// <structure-section> Centralization of all core presentation-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]

            // [INSTANCE PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]

            #endregion

            #region Data Access Layer members
            /// <structure-section> Centralization of all core data-access-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]

            // [INSTANCE DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]

            #endregion
            #endregion

            #region Most definately not in scope
            #region Security members
            /// <structure-section> Centralization of all core security-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC SECURITY MEMBERS]

            // [INSTANCE SECURITY MEMBERS]

            #endregion

            #region Configuration management members
            /// <structure-section> Centralization of all core configuration-management-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC CONFIGURATION-MANAGEMENT MEMBERS]

            // [INSTANCE CONFIGURATION-MANAGEMENT MEMBERS]

            #endregion

            #region Extension-method members
            /// <structure-section> Centralization of all core extension-method-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXTENSION MEMBERS]

            // [INSTANCE EXTENSION MEMBERS]

            #endregion
            #endregion
        }
        /// <summary> [Public] class for [business rule abstract base-class] as [utility] entity; this encapsulates [business rule behaviours that are either concrete/shared, or delegated to inheritors].</summary>
        public abstract class BusinessRuleBase<EvaluationInputType, EvaluationOutputType> : IBusinessRule<EvaluationInputType, EvaluationOutputType>
        {
            /// Explore the Documentation folder for: todo's, rules, concepts, notes and standards.

            #region Backing field members
            /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>

            // [STATIC BACKING FIELD MEMBERS]

            // [INSTANCE BACKING FIELD MEMBERS]
            /// Note: abstract classes require private constructors; they still assume initialization responsibilities over their baseclass members.

            /// <summary> [Private] instance backing field for [business rule identifier] internal state; Enabling [this] to [read a verbose string about the intent of a business rule].</summary>
            private IPurposeIdentifier _purposeIdentifierObject;
            /// <summary> [Private] instance backing field for [business rule strategy] internal state; Enabling [this] to [read a generic-type-delayed signature for business-rule evaluation].</summary>
            private IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType> _strategyObject;

            #endregion

            #region Constructors
            #region Static-data constructor member
            /// <structure-section> Encapsulation of all foundational static member initializations via this default static constructor.</structure-section>

            // [STATIC CONSTRUCTOR MEMBER]
            /// <summary> default static constructor handling all static member initializations.</summary>
            static BusinessRuleBase()
            {
                // [Initialize backing fields: only initialization, no declaration or processing!]
            }
            #endregion

            #region Instance-data constructor members
            /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>

            // [INSTANCE CONSTRUCTOR MEMBERS]
            /// <summary> argumented instance constructor handling (collectively) all instance member initializations.</summary>
            public BusinessRuleBase(IPurposeIdentifier purposeIdentifierObject, IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType> evaluationStrategy)
            {
                // [Initialize backing fields: only initialization, no declaration or processing!]
                _purposeIdentifierObject = purposeIdentifierObject;
                _strategyObject = evaluationStrategy;
            }
            #endregion
            #endregion

            #region General property members
            /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>

            // [STATIC GENERAL PROPERTY MEMBERS]

            // [INSTANCE GENERAL PROPERTY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance property for [identifier interface explicit impl.] exposed state; Enabling [this] to [read the identifier instance].</summary>
            IPurposeIdentifier IBusinessRuleHavingPurposeIdentifier.PurposeIdentifierObject { get; }

            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance property for [strategy interface explicit impl.] exposed state; Enabling [this] to [read the strategy instance].</summary>
            IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType> IBusinessRuleHavingEvaluationStrategy<EvaluationInputType, EvaluationOutputType>.EvaluationStrategy { get; }

            #endregion

            #region Implementing business logic
            #region Business Logic members
            /// <structure-section> Centralization of all core business-logic-encapsulating member; a sole address for any related development.</structure-section>

            // [STATIC MAIN BUSINESS-LOGIC MEMBERS]


            // [INSTANCE MAIN BUSINESS-LOGIC MEMBERS]
            /// <summary> [Expl_interface_impl_private_] instance member for [explicit strategy wrapper] feature; Enabling [others] to [Invoke the handling of the abstract strategy execution].</summary>
            EvaluationOutputType IBusinessRuleHavingEvaluationStrategy<EvaluationInputType, EvaluationOutputType>.ExecuteStrategyLogicWrapper(EvaluationInputType evaluationInput)
            {
                EvaluationOutputType toOverrideableMethodDelegatedOutput = OverrideableExecuteStrategyLogic<EvaluationInputType, EvaluationOutputType>(evaluationInput);
                return toOverrideableMethodDelegatedOutput;
            }

            /// <summary> [Protected] instance member for [overrideable strategy wrapped logic] feature; Enabling [inheritors] to [override the handling of the abstract strategy execution].</summary>
            protected virtual EvaluationOutputType OverrideableExecuteStrategyLogic<OverrideableEvaluationInputType, OverrideableEvaluationOutputType>(EvaluationInputType evaluationInput)
            {
                EvaluationOutputType overrideableMethodOutput = _strategyObject.ExecuteStrategy(evaluationInput);
                return overrideableMethodOutput;
            }

            #endregion

            #region Utility members
            /// <structure-section> Centralization of all core utility-therefore-business-logic-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC UTILITY MEMBERS]

            // [INSTANCE UTILITY MEMBERS]

            #endregion

            #region Delegate members
            /// <code-structure-section> Centralization of all foundational logic-delegating signatures; a sole address for any delegate-related development.</structure-section>

            // [ DELEGATE MEMBERS]
            /// <summary> [Public] delegate for [generate identifier] delegate; Enabling [anyone] to [read the expected signature for this action].</summary>
            public delegate string GenerateIdentifierString<GeneratorInputType>(GeneratorInputType item);

            #endregion
            #endregion

            #region Practical nice to have functionality
            #region Exception Handling members
            /// <structure-section> Centralization of all core exception-handling-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXCEPTION-HANDLING MEMBERS]

            // [INSTANCE EXCEPTION-HANDLING MEMBERS]

            #endregion

            #region Business rule and Validation members
            /// <structure-section> Centralization of all core business-rule/validation-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC BUSINESS-RULE/VALIDATION MEMBERS]

            // [INSTANCE BUSINESS-RULE/VALIDATION MEMBERS]

            #endregion
            #endregion

            #region Technical nice to have functionality
            #region Logging members
            /// <structure-section> Centralization of all core logging-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC LOGGING MEMBERS]

            // [INSTANCE LOGGING MEMBERS]

            #endregion
            #endregion

            #region Probably not in scope
            #region Presentation Layer members
            /// <structure-section> Centralization of all core presentation-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]

            // [INSTANCE PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]

            #endregion

            #region Data Access Layer members
            /// <structure-section> Centralization of all core data-access-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]

            // [INSTANCE DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]

            #endregion
            #endregion

            #region Most definately not in scope
            #region Security members
            /// <structure-section> Centralization of all core security-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC SECURITY MEMBERS]

            // [INSTANCE SECURITY MEMBERS]

            #endregion

            #region Configuration management members
            /// <structure-section> Centralization of all core configuration-management-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC CONFIGURATION-MANAGEMENT MEMBERS]

            // [INSTANCE CONFIGURATION-MANAGEMENT MEMBERS]

            #endregion

            #region Extension-method members
            /// <structure-section> Centralization of all core extension-method-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXTENSION MEMBERS]

            // [INSTANCE EXTENSION MEMBERS]

            #endregion
            #endregion
        }
        /// <summary> [Public] class for [business rule factory] as [utility] entity; this encapsulates [the creation management of a product, in this case a business rule].</summary>
        public class BusinessRuleFactory
        {
            /// Explore the Documentation folder for: todo's, rules, concepts, notes and standards.

            #region Backing field members
            /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>

            // [STATIC BACKING FIELD MEMBERS]
            /// <summary> [Private] static backing field for [singleton factory] internal state; Enabling [this] to [read the singleton factory instance].</summary>
            private static BusinessRuleFactory _businessRuleFactoryInstance;
            /// <summary> [Private] static backing field for [singleton manager] internal state; Enabling [this] to [read the singleton Manager instance].</summary>
            private static BusinessRuleManager _businessRuleManagerInstance;

            // [INSTANCE BACKING FIELD MEMBERS]
            #endregion

            #region Constructors
            #region Static-data constructor member
            /// <structure-section> Encapsulation of all foundational static member initializations via this default static constructor.</structure-section>

            // [STATIC CONSTRUCTOR MEMBER]
            /// <summary> default static constructor handling all static member initializations.</summary>
            private BusinessRuleFactory()
            {
                // [Initialize backing fields: only initialization, no declaration or processing!]
            }

            #endregion

            #region Instance-data constructor members
            /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>

            // [INSTANCE CONSTRUCTOR MEMBERS]
            /// <summary> argumented instance constructor handling (collectively) all instance member initializations.</summary>
            static BusinessRuleFactory()
            {
                // [Initialize backing fields: only initialization, no declaration or processing!]
                _businessRuleManagerInstance = BusinessRuleManager.BusinessRuleManagerInstance;
            }

            #endregion
            #endregion

            #region General property members
            /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>

            // [STATIC GENERAL PROPERTY MEMBERS]
            /// <summary> [Public] static property for [business rule factory] exposed state; Enabling [others] to [read the factory instance].</summary>
            public static BusinessRuleFactory BusinessRuleFactoryInstance
            {
                get
                {
                    if (_businessRuleFactoryInstance == null)
                    {
                        _businessRuleFactoryInstance = new BusinessRuleFactory();
                    }
                    return _businessRuleFactoryInstance;
                }
            }

            // [INSTANCE GENERAL PROPERTY MEMBERS]

            #endregion

            #region Implementing business logic
            #region Business Logic members
            /// <structure-section> Centralization of all core business-logic-encapsulating member; a sole address for any related development.</structure-section>

            // [STATIC MAIN BUSINESS-LOGIC MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static member for [_member_good_title_] feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>

            // [INSTANCE MAIN BUSINESS-LOGIC MEMBERS]
            /// <summary> [Public] instance member for [creating business rules feature]; Enabling [others] to [create products using the factory].</summary>
            public BusinessRule<EvaluationInputType, EvaluationOutputType> CreateBusinessRule<EvaluationInputType, EvaluationOutputType>(IPurposeIdentifier identifier, IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType> evaluationStrategy)
            {
                #region Define a Method flow
                /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC
                BusinessRule<EvaluationInputType, EvaluationOutputType> newBusinessRule = default;

                #endregion
                #region Process a Method flow
                /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES

                // Try to create a new manufactured product with supplied arguments, post an error if unsuccessful.
                try
                {
                    newBusinessRule = new BusinessRule<EvaluationInputType, EvaluationOutputType>(identifier, evaluationStrategy);
                }
                catch (Exception exception)
                {
                    throw new NotImplementedException($"Something went wrong during a business rule constructor call.\nErrormessage: {exception.Message}");
                }

                // Try to pass datachecks for a newly manufactured product, post an error if unsuccessful.
                try
                {
                    ProcessDataChecksOnInput(newBusinessRule);
                }
                catch (Exception exception)
                {
                    throw new NotImplementedException($"Something went wrong during a business rule datachecks call.\nErrormessage: {exception.Message}");
                }

                #endregion
                #region Conclude a Method flow
                /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE

                _businessRuleManagerInstance.AddToSetIfUnique(newBusinessRule);
                return newBusinessRule;

                #endregion
            }

            #endregion

            #region Utility members
            /// <structure-section> Centralization of all core utility-therefore-business-logic-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC UTILITY MEMBERS]

            // [INSTANCE UTILITY MEMBERS]
            /// <summary> [Protected] instance utility member for [input data checks] utility feature; Enabling [inheritors] to [ensure a caller that inputs passed all general data constraints].</summary>
            protected virtual void ProcessDataChecksOnInput<EvaluationInputType, EvaluationOutputType>(BusinessRule<EvaluationInputType, EvaluationOutputType> newBusinessRule)
            {
                #region Define a Method flow
                /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC


                #endregion
                #region Process a Method flow
                /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES


                #endregion
                #region Conclude a Method flow
                /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE

                #endregion
            }

            #endregion

            #region Delegate members
            /// <code-structure-section> Centralization of all foundational logic-delegating signatures; a sole address for any delegate-related development.</structure-section>

            // [ DELEGATE MEMBERS]

            #endregion
            #endregion

            #region Practical nice to have functionality
            #region Exception Handling members
            /// <structure-section> Centralization of all core exception-handling-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXCEPTION-HANDLING MEMBERS]

            // [INSTANCE EXCEPTION-HANDLING MEMBERS]

            #endregion

            #region Business rule and Validation members
            /// <structure-section> Centralization of all core business-rule/validation-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC BUSINESS-RULE/VALIDATION MEMBERS]

            // [INSTANCE BUSINESS-RULE/VALIDATION MEMBERS]

            #endregion
            #endregion

            #region Technical nice to have functionality
            #region Logging members
            /// <structure-section> Centralization of all core logging-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC LOGGING MEMBERS]

            // [INSTANCE LOGGING MEMBERS]

            #endregion
            #endregion

            #region Probably not in scope
            #region Presentation Layer members
            /// <structure-section> Centralization of all core presentation-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]

            // [INSTANCE PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]

            #endregion

            #region Data Access Layer members
            /// <structure-section> Centralization of all core data-access-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]

            // [INSTANCE DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]

            #endregion
            #endregion

            #region Most definately not in scope
            #region Security members
            /// <structure-section> Centralization of all core security-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC SECURITY MEMBERS]

            // [INSTANCE SECURITY MEMBERS]

            #endregion

            #region Configuration management members
            /// <structure-section> Centralization of all core configuration-management-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC CONFIGURATION-MANAGEMENT MEMBERS]

            // [INSTANCE CONFIGURATION-MANAGEMENT MEMBERS]

            #endregion

            #region Extension-method members
            /// <structure-section> Centralization of all core extension-method-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXTENSION MEMBERS]

            // [INSTANCE EXTENSION MEMBERS]

            #endregion
            #endregion
        }
        /// <summary> [Public] class for [business rule manager] as [utility] entity; this encapsulates [The post-creation management of a product, in this case a business rule].</summary>
        public class BusinessRuleManager
        {
            /// Explore the Documentation folder for: todo's, rules, concepts, notes and standards.

            #region Backing field members
            /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>

            // [STATIC BACKING FIELD MEMBERS]
            /// <summary> [Private] static backing field for [business rule manager] internal state; Enabling [this] to [read the manager instance].</summary>
            private static BusinessRuleManager _businessRuleManagerInstance;

            // [INSTANCE BACKING FIELD MEMBERS]
            /// <summary> [private] instance backing field for [business rule exhaustive collection] internal state; Enabling [this] to [read the collection instance].</summary>
            private HashSet<IBusinessRuleHavingPurposeIdentifier> _businessRules;

            #endregion

            #region Constructors
            #region Static-data constructor member
            /// <structure-section> Encapsulation of all foundational static member initializations via this default static constructor.</structure-section>

            // [STATIC CONSTRUCTOR MEMBER]
            /// <summary> default static constructor handling all static member initializations.</summary>
            static BusinessRuleManager()
            {
                // [Initialize backing fields: only initialization, no declaration or processing!]
                _businessRuleManagerInstance = default;
            }

            #endregion

            #region Instance-data constructor members
            /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>

            // [INSTANCE CONSTRUCTOR MEMBERS]
            /// <summary> argumented instance constructor handling (collectively) all instance member initializations.</summary>
            private BusinessRuleManager()
            {
                // [Initialize backing fields: only initialization, no declaration or processing!]
                _businessRules = new HashSet<IBusinessRuleHavingPurposeIdentifier>();
            }

            #endregion
            #endregion

            #region General property members
            /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>

            // [STATIC GENERAL PROPERTY MEMBERS]
            /// <summary> Exposes retrieval/creation of the Factory instance.</summary>
            public static BusinessRuleManager BusinessRuleManagerInstance
            {
                get
                {
                    if (_businessRuleManagerInstance == null)
                    {
                        _businessRuleManagerInstance = new BusinessRuleManager();
                    }
                    return _businessRuleManagerInstance;
                }
            }

            // [INSTANCE GENERAL PROPERTY MEMBERS]

            /// <summary> [Public] instance property for [Readonly Exhaustive Set] exposed state; Enabling [others] to [read the to-read-only-transformed exhaustive set instance].</summary>
            /// Note: The "add" extension method on this set can only be used by the constructor, unaware developers will duplicate by trying to also manually add an item to this set.
            public ReadOnlyCollection<IBusinessRuleHavingPurposeIdentifier> BusinessRulesExhaustiveReadonly { get { return new List<IBusinessRuleHavingPurposeIdentifier>(_businessRules).AsReadOnly(); } }

            /// <summary> [Internal] instance property for [Mutable Exhaustive Set] exposed state; Enabling [internals] to [modify/read the mutable exhaustive set instance].</summary>
            internal HashSet<IBusinessRuleHavingPurposeIdentifier> BusinessRulesExhaustiveMutable { get { return new HashSet<IBusinessRuleHavingPurposeIdentifier>(_businessRules); } }

            #endregion

            #region Implementing business logic
            #region Business Logic members
            /// <structure-section> Centralization of all core business-logic-encapsulating member; a sole address for any related development.</structure-section>

            // [STATIC MAIN BUSINESS-LOGIC MEMBERS]

            // [INSTANCE MAIN BUSINESS-LOGIC MEMBERS]
            /// <summary> [Public] instance member for [Checking collection-entry Uniqueness] feature; Enabling [others] to [provide a target, upon which uniqueness to the exhaustive collection is checked].</summary>
            public virtual void AddToSetIfUnique<EvaluationInputType, EvaluationOutputType>(IBusinessRule<EvaluationInputType, EvaluationOutputType> targetOfCheck)
            {
                bool WasItemUniqueAndAdded = BusinessRulesExhaustiveMutable.Add(targetOfCheck);
                if (!WasItemUniqueAndAdded)
                {
                    string identifierString = targetOfCheck.PurposeIdentifierObject.PurposeIdentifier;
                    throw new InvalidOperationException($"The creation of a duplicate element is prohibited. Supplied identifier:\n'{identifierString}'.");
                }
            }

            #endregion

            #region Utility members
            /// <structure-section> Centralization of all core utility-therefore-business-logic-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC UTILITY MEMBERS]

            // [INSTANCE UTILITY MEMBERS]

            #endregion

            #region Delegate members
            /// <code-structure-section> Centralization of all foundational logic-delegating signatures; a sole address for any delegate-related development.</structure-section>

            // [ DELEGATE MEMBERS]

            #endregion
            #endregion

            #region Practical nice to have functionality
            #region Exception Handling members
            /// <structure-section> Centralization of all core exception-handling-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXCEPTION-HANDLING MEMBERS]

            // [INSTANCE EXCEPTION-HANDLING MEMBERS]

            #endregion

            #region Business rule and Validation members
            /// <structure-section> Centralization of all core business-rule/validation-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC BUSINESS-RULE/VALIDATION MEMBERS]

            // [INSTANCE BUSINESS-RULE/VALIDATION MEMBERS]

            #endregion
            #endregion

            #region Technical nice to have functionality
            #region Logging members
            /// <structure-section> Centralization of all core logging-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC LOGGING MEMBERS]

            // [INSTANCE LOGGING MEMBERS]

            #endregion
            #endregion

            #region Probably not in scope
            #region Presentation Layer members
            /// <structure-section> Centralization of all core presentation-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]

            // [INSTANCE PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]

            #endregion

            #region Data Access Layer members
            /// <structure-section> Centralization of all core data-access-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]

            // [INSTANCE DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]

            #endregion
            #endregion

            #region Most definately not in scope
            #region Security members
            /// <structure-section> Centralization of all core security-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC SECURITY MEMBERS]

            // [INSTANCE SECURITY MEMBERS]

            #endregion

            #region Configuration management members
            /// <structure-section> Centralization of all core configuration-management-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC CONFIGURATION-MANAGEMENT MEMBERS]

            // [INSTANCE CONFIGURATION-MANAGEMENT MEMBERS]

            #endregion

            #region Extension-method members
            /// <structure-section> Centralization of all core extension-method-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXTENSION MEMBERS]

            // [INSTANCE EXTENSION MEMBERS]

            #endregion
            #endregion
        }
        /// <summary> [_private_public_protected_expl_interface_impl_private_] class for [_member_good_title_] as [business_data_utility] entity; this encapsulates [_intent_of_type_].</summary>
        public class PurposeIdentifier : IPurposeIdentifier
        {
            /// Explore the Documentation folder for: todo's, rules, concepts, notes and standards.

            #region Backing field members
            /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>

            // [STATIC BACKING FIELD MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static backing field for [_member_good_title_] internal state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE BACKING FIELD MEMBERS]
            /// <summary> [Private] instance backing field for [Purpose Identifier] internal state; Enabling [this] to [read the purpose identifier instance].</summary>
            private string _purposeIdentifierObject;
            #endregion

            #region Constructors
            #region Static-data constructor member
            /// <structure-section> Encapsulation of all foundational static member initializations via this default static constructor.</structure-section>

            // [STATIC CONSTRUCTOR MEMBER]
            /// <summary> default static constructor handling all static member initializations.</summary>

            // [Initialize backing fields: only initialization, no declaration or processing!]
            #endregion

            #region Instance-data constructor members
            /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>

            // [INSTANCE CONSTRUCTOR MEMBERS]
            /// <summary> argumented instance constructor handling (collectively) all instance member initializations.</summary>

            // [Initialize backing fields: only initialization, no declaration or processing!]
            #endregion
            #endregion

            #region General property members
            /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>

            // [STATIC GENERAL PROPERTY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static property for [_member_good_title_] exposed state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>
            string IPurposeIdentifier.PurposeIdentifier => _purposeIdentifierObject;

            // [INSTANCE GENERAL PROPERTY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance property for [_member_good_title_] exposed state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Implementing business logic
            #region Business Logic members
            /// <structure-section> Centralization of all core business-logic-encapsulating member; a sole address for any related development.</structure-section>

            // [STATIC MAIN BUSINESS-LOGIC MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static member for [_member_good_title_] feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE MAIN BUSINESS-LOGIC MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance member for [_member_good_title_] feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Utility members
            /// <structure-section> Centralization of all core utility-therefore-business-logic-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC UTILITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static utility member for [_member_good_title_] utility feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE UTILITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance utility member for [_member_good_title_] utility feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Delegate members
            /// <code-structure-section> Centralization of all foundational logic-delegating signatures; a sole address for any delegate-related development.</structure-section>

            // [ DELEGATE MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] delegate for [_member_good_title_] delegate; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion

            #region Practical nice to have functionality
            #region Exception Handling members
            /// <structure-section> Centralization of all core exception-handling-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXCEPTION-HANDLING MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static exception-handling member for [_member_good_title_] exception logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE EXCEPTION-HANDLING MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance exception-handling member for [_member_good_title_] exception logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Business rule and Validation members
            /// <structure-section> Centralization of all core business-rule/validation-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC BUSINESS-RULE/VALIDATION MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static business-rule/validation member for [_member_good_title_] validation logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE BUSINESS-RULE/VALIDATION MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance business-rule/validation member for [_member_good_title_] validation logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion

            #region Technical nice to have functionality
            #region Logging members
            /// <structure-section> Centralization of all core logging-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC LOGGING MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static logging member for [_member_good_title_] logging logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE LOGGING MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance logging member for [_member_good_title_] logging logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion

            #region Probably not in scope
            #region Presentation Layer members
            /// <structure-section> Centralization of all core presentation-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static presentation-layer member for [_member_good_title_] presentation logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance presentation-layer member for [_member_good_title_] presentation logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Data Access Layer members
            /// <structure-section> Centralization of all core data-access-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static data-access-layer member for [_member_good_title_] data-access logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance data-access-layer member for [_member_good_title_] data-access logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion

            #region Most definately not in scope
            #region Security members
            /// <structure-section> Centralization of all core security-layer-encapsulating members; a sole address for any related development.</structure-section>
            // [STATIC SECURITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static security-layer member for [_member_good_title_] security logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE SECURITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance security-layer member for [_member_good_title_] security logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Configuration management members
            /// <structure-section> Centralization of all core configuration-management-layer-encapsulating members; a sole address for any related development.</structure-section>
            // [STATIC CONFIGURATION-MANAGEMENT MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static configuration-management-layer member for [_member_good_title_] configuration-management logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE CONFIGURATION-MANAGEMENT MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance configuration-management-layer member for [_member_good_title_] configuration-management logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Extension-method members
            /// <structure-section> Centralization of all core extension-method-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXTENSION MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static extension-method member for [_member_good_title_] extension-method logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE EXTENSION MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance extension-method member for [_member_good_title_] extension-method logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion
        }
    }

    internal class CommentsBasedArchitecture
    {
        private class CommentsBasedArchitectureJustification
        {
            /*
             * Note: The<structure-section> comments architecture
             * This sectional structure:
                * assures that any developer
                    * is able to implement any coding task according to a standardized location
                    * is able to implement any coding task according to a standardized intent
                * assures me that
                    * any development is compliant with my holistic SRP-central coding creed
            */
        }

        private class MethodLevelFlowTemplate
        {
            #region Define a Method flow
            /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC
            /// <summary> [_variable_delegate_reference_expression] to [_compute_load_structure_restructure] a/the [_variable_intent_].</summary>


            #endregion

            #region Process a Method flow
            /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES


            #endregion

            #region Conclude a Method flow
            /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE
            /// <summary> [_reassignment_return_execution] of [_whats_being_concluded_] to [_why_being_concluded_].</summary>


            #endregion
        }

        private class ClassLevelFlowTemplate
        {
            /// <summary> [_private_public_protected_expl_interface_impl_private_] class for [_member_good_title_] as [business_data_utility] entity; this encapsulates [_intent_of_type_].</summary>

            /// Explore the Documentation folder for: todo's, rules, concepts, notes and standards.

            #region Backing field members
            /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>

            // [STATIC BACKING FIELD MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static backing field for [_member_good_title_] internal state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE BACKING FIELD MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance backing field for [_member_good_title_] internal state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>

            #endregion

            #region Constructors
            #region Static-data constructor member
            /// <structure-section> Encapsulation of all foundational static member initializations via this default static constructor.</structure-section>

            // [STATIC CONSTRUCTOR MEMBER]
            /// <summary> default static constructor handling all static member initializations.</summary>

            // [Initialize backing fields: only initialization, no declaration or processing!]
            #endregion

            #region Instance-data constructor members
            /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>

            // [INSTANCE CONSTRUCTOR MEMBERS]
            /// <summary> argumented instance constructor handling (collectively) all instance member initializations.</summary>

            // [Initialize backing fields: only initialization, no declaration or processing!]
            #endregion
            #endregion

            #region General property members
            /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>

            // [STATIC GENERAL PROPERTY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static property for [_member_good_title_] exposed state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE GENERAL PROPERTY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance property for [_member_good_title_] exposed state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Implementing business logic
            #region Business Logic members
            /// <structure-section> Centralization of all core business-logic-encapsulating member; a sole address for any related development.</structure-section>

            // [STATIC MAIN BUSINESS-LOGIC MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static member for [_member_good_title_] feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE MAIN BUSINESS-LOGIC MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance member for [_member_good_title_] feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Utility members
            /// <structure-section> Centralization of all core utility-therefore-business-logic-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC UTILITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static utility member for [_member_good_title_] utility feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE UTILITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance utility member for [_member_good_title_] utility feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Delegate members
            /// <code-structure-section> Centralization of all foundational logic-delegating signatures; a sole address for any delegate-related development.</structure-section>

            // [ DELEGATE MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] delegate for [_member_good_title_] delegate; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion

            #region Practical nice to have functionality
            #region Exception Handling members
            /// <structure-section> Centralization of all core exception-handling-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXCEPTION-HANDLING MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static exception-handling member for [_member_good_title_] exception logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE EXCEPTION-HANDLING MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance exception-handling member for [_member_good_title_] exception logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Business rule and Validation members
            /// <structure-section> Centralization of all core business-rule/validation-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC BUSINESS-RULE/VALIDATION MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static business-rule/validation member for [_member_good_title_] validation logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE BUSINESS-RULE/VALIDATION MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance business-rule/validation member for [_member_good_title_] validation logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion

            #region Technical nice to have functionality
            #region Logging members
            /// <structure-section> Centralization of all core logging-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC LOGGING MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static logging member for [_member_good_title_] logging logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE LOGGING MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance logging member for [_member_good_title_] logging logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion

            #region Probably not in scope
            #region Presentation Layer members
            /// <structure-section> Centralization of all core presentation-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static presentation-layer member for [_member_good_title_] presentation logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE PRESENTATION LAYER: MVC-CONTROLLER/MVVM-VIEWMODEL MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance presentation-layer member for [_member_good_title_] presentation logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Data Access Layer members
            /// <structure-section> Centralization of all core data-access-layer-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static data-access-layer member for [_member_good_title_] data-access logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE DATA ACCESS LAYER: PERSISTENCE/REPOSITORY/DATACONTEXT/ENTITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance data-access-layer member for [_member_good_title_] data-access logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion

            #region Most definately not in scope
            #region Security members
            /// <structure-section> Centralization of all core security-layer-encapsulating members; a sole address for any related development.</structure-section>
            // [STATIC SECURITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static security-layer member for [_member_good_title_] security logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE SECURITY MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance security-layer member for [_member_good_title_] security logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Configuration management members
            /// <structure-section> Centralization of all core configuration-management-layer-encapsulating members; a sole address for any related development.</structure-section>
            // [STATIC CONFIGURATION-MANAGEMENT MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static configuration-management-layer member for [_member_good_title_] configuration-management logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE CONFIGURATION-MANAGEMENT MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance configuration-management-layer member for [_member_good_title_] configuration-management logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion

            #region Extension-method members
            /// <structure-section> Centralization of all core extension-method-encapsulating members; a sole address for any related development.</structure-section>

            // [STATIC EXTENSION MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] static extension-method member for [_member_good_title_] extension-method logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            // [INSTANCE EXTENSION MEMBERS]
            /// <summary> [_private_public_protected_expl_interface_impl_private_] instance extension-method member for [_member_good_title_] extension-method logic; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


            #endregion
            #endregion
        }
    }
}
