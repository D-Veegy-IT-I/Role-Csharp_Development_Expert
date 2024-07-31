using CommonCode.Utility;

namespace CommonCode.Interfaces
{
    /// <summary> Interface-intent: Business-rule-members that enable intent identification/verbosity by delegate-generation, then property-exposition.</summary>
    public interface IBusinessRuleHavingPurposeIdentifier
    {
        IPurposeIdentifier PurposeIdentifierObject { get; }
    }
}
