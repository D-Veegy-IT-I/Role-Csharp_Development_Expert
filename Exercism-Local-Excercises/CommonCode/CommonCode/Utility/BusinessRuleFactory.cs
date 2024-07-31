using CommonCode.BusinessRules;
using CommonCode.Interfaces;
using CommonCode.Interfaces.Strategy;
using System;


namespace CommonCode.Utility
{
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
        private BusinessRuleFactory(){
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
}