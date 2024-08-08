using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/* Custom Type Aliases */
using StringStepLogicFunc = System.Func<string, string>;
using StringStepTitleToStepLogicDictionary = System.Collections.Generic.Dictionary<string, System.Func<string, string>>;
using ConditionStepLogicFunc = System.Func<int, int, bool>;
using ConditionTitleToConditionLogicDictionary = System.Collections.Generic.Dictionary<string, System.Func<int, int, bool>>;

public static class CryptoSquare
{
    public static string NormalizedPlaintext(string plaintext)
    {
        /* Issue: Can't change the bad name of this enclosing method: Method names should be verbs describing the process, not nouns describing the output. */
        /* Issue: Bad design of this enclosing method: This is an underlying mechism to the solely-used-in-testing Ciphertext method; it should not be public. */
        string imNotReturningSquatForThisWeirdMethod = default;
        return imNotReturningSquatForThisWeirdMethod;
    }

    public static IEnumerable<string> PlaintextSegments(string plaintext)
    {
        /* Issue: Can't change the bad name of this enclosing method: Method names should be verbs describing the process, not nouns describing the output. */
        /* Issue: Bad design of this enclosing method: This is an underlying mechism to the solely-used-in-testing Ciphertext method; it should not be public. */
        IEnumerable<string> imNotReturningSquatForThisWeirdMethod = default;
        return imNotReturningSquatForThisWeirdMethod;
    }

    public static string Encoded(string plaintext)
    {
        /* Issue: Can't change the bad name of this enclosing method: Method names should be verbs describing the process, not nouns describing the output. */
        /* Issue: Bad design of this enclosing method: This is an underlying mechism to the solely-used-in-testing Ciphertext method; it should not be public. */
        string imNotReturningSquatForThisWeirdMethod = default;
        return imNotReturningSquatForThisWeirdMethod;
    }

    public static string Ciphertext(string plaintext)
    {
        /* Issue: Can't change the bad name of this enclosing method: Method names should be verbs describing the process, not nouns describing the output. */

        #region Define a Method flow
        /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC
        string outputAsCipheredText = default;
        string LiteralNameForTypeOfStep = "Cipher";

        /// <summary> [variable] to [structure] the [normalization steps between a string and plain text].</summary>
        StringStepTitleToStepLogicDictionary dicCipherSteps = new StringStepTitleToStepLogicDictionary
        {
            { "cipherStepNormalizeToPlainText", inputText => NormalizeInputText(inputText) }
        };

        SafeStringProcedureStepManager safeProcedureStepManager = new SafeStringProcedureStepManager(LiteralNameForTypeOfStep, dicCipherSteps);

        #endregion

        #region Process a Method flow
        /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES
        outputAsCipheredText = safeProcedureStepManager.ApplyAllSteps(plaintext, dicCipherSteps);

        #endregion

        #region Conclude a Method flow
        /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE
        return outputAsCipheredText;

        #endregion
    }

    private static IEnumerable<string> SegmentStringIntoSquare()
    {
        #region Define a Method flow
        /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC
        /// <summary> [_variable_delegate_reference_expression] to [_compute_load_structure_restructure] a/the [_variable_intent_].</summary>
        string outputAsSegmentStringIntoSquareText = default;
        string literalNameForTypeOfStep = "SegmentStringIntoSquare";

        /// <summary> [variable] to [structure] the [normalization steps between a string and plain text].</summary>
        StringStepTitleToStepLogicDictionary dicSegmentStringIntoSquareSteps = new StringStepTitleToStepLogicDictionary
        {
            { "SegmentStringIntoSquareStepCalculateRows", inputText => NormalizeInputText(inputText) }
        };

        int CalculateRowsForSquareShapedTextSegments(string inputText)
        {
            int _squareColumns = default;
            int _squareRows = default;

            ConditionTitleToConditionLogicDictionary dicSegmentStringIntoSquareSteps = new ConditionTitleToConditionLogicDictionary
            {
                { "isRowsAndColumnsNotZero", (squareColumns, squareRows) => ((squareColumns != 0) && (squareRows != 0)) },
                { "isRowsLowerThanColumns", (squareColumns, squareRows) => (squareColumns >= squareRows - 1) },
                { "isRowsLowerThanColumns", (squareColumns, squareRows) => (squareColumns * squareRows == inputText.Length) },
                { "isColumnMaximallyOneHigherThanRows", (squareColumns, squareRows) => (squareColumns != 0) && (squareRows != 0) },
                { "isAmountOfRowsOrColumnsNotEqualToStringLength", (squareColumns, squareRows) => (squareRows != inputText.Length) || (squareColumns != inputText.Length) }
            };

            SafeConditionalProcedureStepManager safeConditionalProcedureStepManager = new SafeConditionalProcedureStepManager(literalNameForTypeOfStep, dicSegmentStringIntoSquareSteps);

            (int squareColumns, int squareRows) CalculateDimensionsOfSquare()
            {
                (int _amountOfRowsAfterLoop, int _amountOfColumnsAfterLoop, bool didLoopReachedOuterBound) loopData = default;
                int _amountOfRows = default;
                int _amountOfColumns = default;
                int _iterateAllDimensionCombinationsOuterBound = inputText.Length;

                for (int counter = 0; counter < _iterateAllDimensionCombinationsOuterBound; counter++)
                {
                    /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC
                    void IncreaseColumnsByOne() => _squareColumns++;
                    void IncreaseRowsByOne() => _squareRows++;
                    bool CheckIfCurrentDimensionSatisfiesAllConditions(int _squareColumns, int _squareRows) => safeConditionalProcedureStepManager.ApplyAllSteps(_squareColumns, _squareRows);

                    /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES
                    IncreaseColumnsByOne();
                    if (CheckIfCurrentDimensionSatisfiesAllConditions(_squareColumns, _squareRows))
                    {
                        loopData._amountOfRowsAfterLoop = _amountOfRows;
                        loopData._amountOfColumnsAfterLoop = _amountOfColumns;
                        break;
                    }
                    IncreaseRowsByOne();
                    if (CheckIfCurrentDimensionSatisfiesAllConditions(_squareColumns, _squareRows))
                    {
                        loopData._amountOfRowsAfterLoop = _amountOfRows;
                        loopData._amountOfColumnsAfterLoop = _amountOfColumns;
                        break;
                    }

                    if (counter == _iterateAllDimensionCombinationsOuterBound) loopData.didLoopReachedOuterBound = true;
                }
                finall
                if (safeConditionalProcedureStepManager.ApplyAllSteps(_squareColumns, _squareRows)) return (_squareColumns, _squareRows);
                throw new Exception("this shit aint right");
            }
        }

        SafeStringProcedureStepManager safeProcedureStepManager = new SafeStringProcedureStepManager(literalNameForTypeOfStep, dicSegmentStringIntoSquareSteps);

        #endregion

        #region Process a Method flow
        /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES


        #endregion

        #region Conclude a Method flow
        /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE
        /// <summary> [_reassignment_return_execution] of [_whats_being_concluded_] to [_why_being_concluded_].</summary>


        #endregion
    }

    private static string NormalizeInputText(string inputToBeNormalized)
    {
        #region Define a Method flow
        /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC
        string outputAsPlainText = default;
        string LiteralNameForTypeOfStep = "Normalization";

        /// <summary> [variable] to [structure] the [normalization steps between a string and plain text].</summary>
        StringStepTitleToStepLogicDictionary dicNormalizationSteps = new StringStepTitleToStepLogicDictionary
        {
            { "normalizationStepRemoveSpaces", input => Regex.Replace(input, @"[\s]", "") },
            {"normalizationStepRemovePunctuation", input => Regex.Replace(input, @"[\p{P}]", "") },
            { "normalizationStepTransformToLowercase", input => input.ToLower()}
        };

        SafeStringProcedureStepManager safeProcedureStepManager = new SafeStringProcedureStepManager(LiteralNameForTypeOfStep, dicNormalizationSteps);

        #endregion

        #region Process a Method flow
        /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES
        outputAsPlainText = safeProcedureStepManager.ApplyAllSteps(inputToBeNormalized);

        #endregion

        #region Conclude a Method flow
        /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE
        return outputAsPlainText;

        #endregion
    }


    /// <summary> [private] class for [Safely computing a tranformative (string) procedural output] as [utility] entity; this encapsulates [Exception-secured collection of transformative steps, performed on a single string].</summary>
    private class SafeStringProcedureStepManager
    {
        #region Backing field members
        /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>


        // [INSTANCE BACKING FIELD MEMBERS]
        /// <summary> [private] instance backing field for [Procedure step title and logic dictionary] internal state; Enabling [this] to [read the steps necessary to compute a procedural output].</summary>
        private readonly StringStepTitleToStepLogicDictionary _dicSteps;
        /// <summary> [private] instance backing field for [Specifying the literal type of procedure] internal state; Enabling [this] to [read the identifying string for this procedure].</summary>
        private readonly string _typeOfStep;
        #endregion

        #region Constructors

        #region Instance-data constructor members
        /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>

        // [INSTANCE CONSTRUCTOR MEMBERS]
        /// <summary> argumented instance constructor handling (collectively) all instance member initializations.</summary>
        public SafeStringProcedureStepManager(string typeOfStep, StringStepTitleToStepLogicDictionary steps)
        {
            // [Initialize backing fields: only initialization, no declaration or processing!]
            _typeOfStep = typeOfStep;
            _dicSteps = steps;
        }
        #endregion
        #endregion

        #region General property members
        /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>


        // [INSTANCE GENERAL PROPERTY MEMBERS]
        /// <summary> [private] instance property for [Encapsulating the literal type of procedure] exposed state; Enabling [this] to [read the identifying string for this procedure].</summary>
        private string TypeOfStep
        {
            get { return _typeOfStep; }
        }

        /// <summary> [private] instance property for [Encapsulating the procedure step title and logic dictionary] exposed state; Enabling [this] to [read the steps necessary to compute a procedural output].</summary>
        private StringStepTitleToStepLogicDictionary DicSteps
        {
            get { return _dicSteps; }
        }


        #endregion

        #region Implementing business logic
        #region Business Logic members
        /// <structure-section> Centralization of all core business-logic-encapsulating member; a sole address for any related development.</structure-section>


        // [INSTANCE MAIN BUSINESS-LOGIC MEMBERS]
        /// <summary> [function] to [safely process] the [application of any step to a target, reporting issues by a step title].</summary>
        public string ApplyStepToOutput(string stepTarget, StringStepLogicFunc step, string stepTitle)
        {
            try
            {
                return step(stepTarget);
            }
            catch (Exception exception)
            {
                string exceptionTechnicalDetails = $"\"{exception.Message}\" of type \"{exception.GetType().FullName}\"";
                string exceptionVerboseMessage = $"{TypeOfStep} step \"{stepTitle}\" failed due to exception:\n{exceptionTechnicalDetails}";
                throw new Exception(exceptionVerboseMessage);
            }
        }

        /// <summary> [function] to [delegate] the [application of all normalization steps inside of the respective container structure on a target].</summary>
        public string ApplyAllSteps(string stepTarget)
        {
            return DicSteps.Aggregate(stepTarget, (currentStateOfstepTarget, step) => ApplyStepToOutput(currentStateOfstepTarget, step.Value, step.Key));
        }

        #endregion

        
        #endregion
    }

    /// <summary> [private] class for [Safely computing a conditional procedural output] as [utility] entity; this encapsulates [Exception-secured collection of transformative steps, performed on a single string].</summary>
    private class SafeConditionalProcedureStepManager
    {
        #region Backing field members
        /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>


        // [INSTANCE BACKING FIELD MEMBERS]
        /// <summary> [private] instance backing field for [Procedure step title and logic dictionary] internal state; Enabling [this] to [read the steps necessary to compute a procedural output].</summary>
        private readonly ConditionTitleToConditionLogicDictionary _dicSteps;
        /// <summary> [private] instance backing field for [Specifying the literal type of procedure] internal state; Enabling [this] to [read the identifying string for this procedure].</summary>
        private readonly string _typeOfStep;
        #endregion

        #region Constructors

        #region Instance-data constructor members
        /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>

        // [INSTANCE CONSTRUCTOR MEMBERS]
        /// <summary> argumented instance constructor handling (collectively) all instance member initializations.</summary>
        public SafeConditionalProcedureStepManager(string typeOfStep, ConditionTitleToConditionLogicDictionary steps)
        {
            // [Initialize backing fields: only initialization, no declaration or processing!]
            _typeOfStep = typeOfStep;
            _dicSteps = steps;
        }
        #endregion
        #endregion

        #region General property members
        /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>


        // [INSTANCE GENERAL PROPERTY MEMBERS]
        /// <summary> [private] instance property for [Encapsulating the literal type of procedure] exposed state; Enabling [this] to [read the identifying string for this procedure].</summary>
        private string TypeOfStep
        {
            get { return _typeOfStep; }
        }

        /// <summary> [private] instance property for [Encapsulating the procedure step title and logic dictionary] exposed state; Enabling [this] to [read the steps necessary to compute a procedural output].</summary>
        private ConditionTitleToConditionLogicDictionary DicSteps
        {
            get { return _dicSteps; }
        }


        #endregion

        #region Implementing business logic
        #region Business Logic members
        /// <structure-section> Centralization of all core business-logic-encapsulating member; a sole address for any related development.</structure-section>


        // [INSTANCE MAIN BUSINESS-LOGIC MEMBERS]
        /// <summary> [function] to [safely process] the [application of any step to a target, reporting issues by a step title].</summary>
        public bool ApplyStepToOutput(int conditionFirstArgument, int conditionSecondArgument, ConditionStepLogicFunc step, string stepTitle)
        {
            try
            {
                return step(conditionFirstArgument, conditionSecondArgument);
            }
            catch (Exception exception)
            {
                string exceptionTechnicalDetails = $"\"{exception.Message}\" of type \"{exception.GetType().FullName}\"";
                string exceptionVerboseMessage = $"{TypeOfStep} step \"{stepTitle}\" failed due to exception:\n{exceptionTechnicalDetails}";
                throw new Exception(exceptionVerboseMessage);
            }
        }

        /// <summary> [function] to [delegate] the [application of all normalization steps inside of the respective container structure on a target].</summary>
        public bool ApplyAllSteps(int conditionFirstArgument, int conditionSecondArgument)
        {
            return DicSteps.Aggregate(true, (current, step) => current && ApplyStepToOutput(conditionFirstArgument, conditionSecondArgument, step.Value, step.Key));
        }

        #endregion


        #endregion
    }
}