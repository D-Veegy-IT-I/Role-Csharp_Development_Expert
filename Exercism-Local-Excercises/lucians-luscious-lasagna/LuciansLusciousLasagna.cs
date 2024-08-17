using System;
using System.Collections.Generic;

class Lasagna
{
    public interface ILasagnaProcedureBase
    {
        const int LASAGNA_TOTAL_TIME_IN_OVEN = 40;

        static Func<dynamic, dynamic> ProcedureStepLogic { get;}
        dynamic ProcedureStepLogicArguments { get;}
        dynamic ProcedureStepOutput { get; }
        string ProcedureStepVerboseDescription { get; }
    }

    public interface ILasagnaProcedureStepReturnTotalMinutesInOven : ILasagnaProcedureBase
    {
        
    }

    public interface ILasagnaProcedureStepMinutesInOvenRemaining : ILasagnaProcedureBase
    {
        
    }

    public class LasagnaProcedureStepData() : ILasagnaProcedureBase, ILasagnaProcedureStepMinutesInOvenRemaining, ILasagnaProcedureStepReturnTotalMinutesInOven
    {
        private const string DEFAULT_PROCEDURE_VERBOSE_DESCRIPTION = "no desciption given for this process step";

        public LasagnaProcedureStepData(Func<dynamic, dynamic> procedureStepLogic, dynamic  procedureStepLogicArguments, string procedureStepVerboseDescription = DEFAULT_PROCEDURE_VERBOSE_DESCRIPTION) : this()
        {
            ProcedureStepLogic = procedureStepLogic;
            ProcedureStepLogicArguments = procedureStepLogicArguments;
            ProcedureStepVerboseDescription = procedureStepVerboseDescription;
        }
        
        public Func<dynamic, dynamic> ProcedureStepLogic { get; private set; }
        public dynamic ProcedureStepLogicArguments { get; private set; }
        public string ProcedureStepVerboseDescription { get; private set; }

        public dynamic ProcedureStepOutput
        {
            get { return ProcedureStepLogic(ProcedureStepLogicArguments); }
        }

        public static Func<dynamic, dynamic> ConvertToDynamicWrapper(Delegate originalFunction)
        {
            return new Func<dynamic, dynamic>((dynamic param) =>
            {
                // Unpack the dynamic parameter into an array of arguments
                var args = ((object[])param);

                // Use DynamicInvoke to call the original function with the unpacked arguments
                var result = originalFunction.DynamicInvoke(args);

                // Return the result as dynamic
                return (dynamic)result;
            });
        }
    }

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(int minutesAlreadyInOven)
    {
        #region Define a Method flow
        /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC

        int procedureStepOutput = default(int);

        dynamic ProcessMethodFlowSafely(ILasagnaProcedureStepMinutesInOvenRemaining lasagnaProcedureData)
        {
            Dictionary<Type, Exception> _items = new Dictionary<Type, Exception>();
            _items.Add(typeof(Exception), new Exception("There was a miscast between the dynamic typing of the abstract procedure-step architecture and the specific instance thereof"));

            Func<ILasagnaProcedureStepMinutesInOvenRemaining, int> action = (ILasagnaProcedureStepMinutesInOvenRemaining lasagnaProcedureData) => {
                return (int)lasagnaProcedureData.ProcedureStepOutput;
            };

            return ExecuteWithExceptionHandling(_items, action);
        }

        LasagnaProcedureStepData ConstructLasagnaProcedureStepData()
        {
            dynamic ConstructProcedureStepLogicDynamic()
            {
                // Construct the delegate encapsulating the procedure-step-specific logic
                Func<(int lasagnaTimeInOvenRecipe, int lasagnaTimeInOvenCurrent), int> procedureStepLogic =
                new Func<(int lasagnaTimeInOvenRecipe, int lasagnaTimeInOvenCurrent), int>((lasagnaTimeInOvenData) =>
                {
                    return lasagnaTimeInOvenData.lasagnaTimeInOvenRecipe - lasagnaTimeInOvenData.lasagnaTimeInOvenCurrent;
                });

                // Convert the constructed delegate's type to the required dynamic type
                dynamic procedureStepLogicDynamic = LasagnaProcedureStepData.ConvertToDynamicWrapper(procedureStepLogic);

                // Return the result
                return procedureStepLogicDynamic;
            }
            dynamic procedureStepLogicDynamic = ConstructProcedureStepLogicDynamic();
            dynamic procedureStepArgumentsDynamic = (ILasagnaProcedureBase.LASAGNA_TOTAL_TIME_IN_OVEN, minutesAlreadyInOven);
            string procedureStepVerboseDescription = "Calculating the amount of time in oven remainder";

            return new LasagnaProcedureStepData(
            procedureStepLogicDynamic,
            procedureStepArgumentsDynamic,
            procedureStepVerboseDescription
            );
        }

        ILasagnaProcedureStepMinutesInOvenRemaining lasagnaProcedureData = ConstructLasagnaProcedureStepData();
        #endregion

        #region Process a Method flow
        /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES

        procedureStepOutput = (int)ProcessMethodFlowSafely(lasagnaProcedureData);


        #endregion

        #region Conclude a Method flow
        /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE
        return procedureStepOutput;

        #endregion
    }

    public static dynamic ExecuteWithExceptionHandling(Dictionary<Type, Exception> items, Delegate methodToExecute, params object[] methodArguments)
    {
        try
        {
            // Invoke the delegate with the provided arguments
            return methodToExecute.DynamicInvoke(methodArguments);
        }
        catch (Exception exception)
        {
            Exception RetrieveExceptionFromCollection(Type targetType) => items[targetType];
            switch (exception)
            {
                case Exception i:
                    throw RetrieveExceptionFromCollection(typeof(Exception));
                default:
                    throw new Exception(exception.Message);
            }
        }
    }


    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesAlreadyInOven)
    {
        /* Define: Declare and Initialise variables */
        // Define-sub: Output Variables
        int output = default;
        // Define-sub: Process Variables
        const int lasagnaCookingTime = 40;
        (int MinutesAlreadyInOven, int LasagnaCookingTime) lasagnaCookingData = (MinutesAlreadyInOven: minutesAlreadyInOven, LasagnaCookingTime: lasagnaCookingTime);
        // Define-sub: Process actions
        Func<(int, int), int> actionCalculateRemainingMinutesInOven = ((int MinutesAlreadyInOven, int LasagnaCookingTime) lasagnaCookingData) =>
        {
            return (lasagnaCookingData.LasagnaCookingTime - lasagnaCookingData.MinutesAlreadyInOven);
        };

        /* Process: Perform logic on defined variables */
        output = actionCalculateRemainingMinutesInOven(lasagnaCookingData);

        /* Conclude: Perform the method intent (output data) */
        return output;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int amountOfLayersInLasagna)
    {
        /* [Define] Declare and Initialise variables */
        // (Define-sub) Output Variables
        int output = default;
        // (Define-sub) Process Variables
        const int preparationTimeInMinutesPerLayer = 2;
        (int AmountOfLayersInLasagna, int PreparationTimeInMinutesPerLayer) lasagnaCookingData = (AmountOfLayersInLasagna: amountOfLayersInLasagna, PreparationTimeInMinutesPerLayer: preparationTimeInMinutesPerLayer);
        // (Define-sub) Process actions
        Func<(int, int), int> actionCalculatePreparationTimeInMinutesBasedOnLayers = ((int AmountOfLayersInLasagna, int PreparationTimeInMinutesPerLayer) lasagnaCookingData) =>
        {
            return (lasagnaCookingData.AmountOfLayersInLasagna * lasagnaCookingData.PreparationTimeInMinutesPerLayer);
        };

        /* [Process] Perform logic on defined variables */
        output = actionCalculatePreparationTimeInMinutesBasedOnLayers(lasagnaCookingData);

        /* [Conclude] Perform the method intent (output data) */
        return output;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int amountOfLayersInLasagna, int minutesAlreadyInOven)
    {
        /* [Define] Declare and Initialise variables */
        // (Define-sub) Output Variables
        int output = default;
        // (Define-sub) Process Variables
        (int PreparationTime, int MinutesAlreadyInOven) lasagnaCookingData = (PreparationTime: PreparationTimeInMinutes(amountOfLayersInLasagna), MinutesAlreadyInOven: minutesAlreadyInOven);
        // (Define-sub) Process actions
        Func<(int, int), int> actionCalculatePreparationTimeInMinutesBasedOnLayers = ((int PreparationTime, int MinutesAlreadyInOven) lasagnaCookingData) =>
        {
            return (lasagnaCookingData.PreparationTime + lasagnaCookingData.MinutesAlreadyInOven);
        };

        /* [Process] Perform logic on defined variables */
        output = actionCalculatePreparationTimeInMinutesBasedOnLayers(lasagnaCookingData);

        /* [Conclude] Perform the method intent (output data) */
        return output;
    }
}

class Template
{
    public int TemplateMethod(int amountOfLayersInLasagna)
    {
        /* [Define] Declare and Initialise variables */
        // (Define-sub) Output Variables
        int output = default;
        // (Define-sub) Process Variables
        const int preparationTimeInMinutesPerLayer = 2;
        (int AmountOfLayersInLasagna, int PreparationTimeInMinutesPerLayer) lasagnaCookingData = (AmountOfLayersInLasagna: amountOfLayersInLasagna, PreparationTimeInMinutesPerLayer: preparationTimeInMinutesPerLayer);
        // (Define-sub) Process actions
        Func<(int, int), int> actionCalculatePreparationTimeInMinutesBasedOnLayers = ((int AmountOfLayersInLasagna, int PreparationTimeInMinutesPerLayer) lasagnaCookingData) =>
        {
            return (lasagnaCookingData.AmountOfLayersInLasagna * lasagnaCookingData.PreparationTimeInMinutesPerLayer);
        };

        /* [Process] Perform logic on defined variables */
        output = actionCalculatePreparationTimeInMinutesBasedOnLayers(lasagnaCookingData);

        /* [Conclude] Perform the method intent (output data) */
        return output;
    }
}
