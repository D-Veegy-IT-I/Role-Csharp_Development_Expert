namespace CommonCode.Interfaces
{
    /// <summary> Type guarantee for having a Business rule Evaluation strategy and Mounting point for ISP interfaces.</summary>
    public interface IBusinessRule<EvaluationInputType, EvaluationOutputType> : IBusinessRuleHavingPurposeIdentifier, IBusinessRuleHavingEvaluationStrategy<EvaluationInputType, EvaluationOutputType>
    {
        
    }
}
