using CommonCode.Interfaces;

namespace PhoneNumberAnalysis
{
    internal class StrategyDoesTargetSubstringEqualPattern /*: IBusinessRuleWithEvaluationStrategy<(string target, int targetSubstringStart, int targetSubstringLength, string pattern), bool>*/
    {
        #region Backing field members
        /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>
        // [STATIC BACKING FIELD MEMBERS]

        // [INSTANCE BACKING FIELD MEMBERS]
        #endregion

        #region Constructors
        #region Static-data constructor member
        /// <structure-section> Encapsulation of all foundational static member initializations via this default static constructor.</structure-section>
        // [STATIC CONSTRUCTOR MEMBER]
        // [Instantiate backing fields]

        // [Instantiate (auto) properties]
        #endregion

        #region Instance-data constructor members
        /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>
        // [INSTANCE CONSTRUCTOR MEMBERS]
        // [Instantiate backing fields]

        // [Instantiate (auto) properties]
        #endregion
        #endregion

        #region General property members
        /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>
        // [STATIC GENERAL PROPERTY MEMBERS]

        // [INSTANCE GENERAL PROPERTY MEMBERS]
        #endregion

        #region Implementing business logic
        #region Business Logic members
        /// <structure-section> Centralization of all core business-logic-encapsulating methods; a sole address for any related development.</structure-section>
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
        /// <structure-section> Centralization of all core security-encapsulating members; a sole address for any related development.</structure-section>
        // [STATIC SECURITY MEMBERS]

        // [INSTANCE SECURITY MEMBERS]
        #endregion

        #region Configuration management members
        /// <structure-section> Centralization of all core configuration-management-encapsulating members; a sole address for any related development.</structure-section>
        // [STATIC CONFIGURATION-MANAGEMENT MEMBERS]

        // [INSTANCE CONFIGURATION-MANAGEMENT MEMBERS]
        #endregion

        #region Extension-method members
        /// <structure-section> Centralization of all core extension-method-encapsulating members; a sole address for any related development.</structure-section>
        // [STATIC EXTENSION MEMBERS]

        // [INSTANCE EXTENSION MEMBERS]
        #endregion
        #endregion
















        // [Delegate Signatures]
        //public delegate bool ProduceEvaluatedResult(string target, string pattern);

        // [STATIC Backing Fields]
        // [INSTANCE Backing Fields]
        //private string _pattern;
        //private string _target;
        //private (int targetSubstringStart, int targetSubstringLength) _targetSubstringData;

        // [STATIC Constructor member]
        //static StrategyDoesTargetSubstringEqualPattern()
        //{
        //    // [Instantiate backing fields]
        //    // [Instantiate (auto) properties]
        //}
        // [INSTANCE Constructor members]
        //public StrategyDoesTargetSubstringEqualPattern(string target, int targetSubstringStart, int targetSubstringLength, string pattern)
        //{
        //    // [Instantiate backing fields]
        //    _target = target;
        //    _pattern = pattern;
        //    _targetSubstringData = (targetSubstringStart, targetSubstringLength);
        //    // [Instantiate (auto) properties]
        //}

        // [STATIC Property members]
        // [INSTANCE Property members]
        //public string Pattern { get { return _pattern; } protected set { _pattern = value; } }
        //public string Target { get { return _target; } protected set { _target = value; } }
        //public (int targetSubstringStart, int targetSubstringLength) TargetSubstringData { get { return _targetSubstringData; } protected set { _targetSubstringData = value; } }

        // [STATIC Method members]
        // [INSTANCE Method members]
        //private bool CheckIfTargetSubstringEqualsPattern()
        //{
        //    string substring = _target.Substring(TargetSubstringData.targetSubstringStart, TargetSubstringData.targetSubstringLength);
        //    return substring.Equals(_pattern);
        //}

        // [STATIC Helper Method members]
        // [INSTANCE Helper Method members]

        // [STATIC Logger Method members]
        // [STATIC ErrorHandler Method members]

        // [Interface Members]
        //public bool ExecuteStrategy()
        //{
        //    return CheckIfTargetSubstringEqualsPattern();
        //}
    }
}
