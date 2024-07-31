using CommonCode.Interfaces;
using CommonCode.Interfaces.Strategy;
using CommonCode.Utility;

namespace CommonCode.BusinessRules
{
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
        internal BusinessRule(IPurposeIdentifier purposeIdentifierObject, IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType> evaluationStrategy): base(purposeIdentifierObject, evaluationStrategy)
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
}