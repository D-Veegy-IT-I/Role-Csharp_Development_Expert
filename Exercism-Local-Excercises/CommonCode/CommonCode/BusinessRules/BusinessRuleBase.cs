using CommonCode.Interfaces;
using CommonCode.Interfaces.Strategy;
using CommonCode.Utility;
using System;

namespace CommonCode.BusinessRules
{
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

}