using CommonCode.BusinessRules;
using CommonCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CommonCode.Utility
{
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
}