using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCode.Interfaces.Strategy
{
    public interface IBusinessRuleEvaluationStrategy<EvaluationInputType, EvaluationOutputType>
    {
        EvaluationOutputType ExecuteStrategy(EvaluationInputType evaluationInput);
    }
}
