using System;
using System.Collections.Generic;
using System.Threading;

class Lasagna
{
    

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
            dynamic procedureStepArgumentsDynamic = (ILasagnaProcedureStepBase.LASAGNA_TOTAL_TIME_IN_OVEN, minutesAlreadyInOven);
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


public class ProcedureFactory()
{
    public interface IProcedureBase
    {

    }
    public interface IProcedureStepBase
    {
        const int LASAGNA_TOTAL_TIME_IN_OVEN = 40;

        static Func<dynamic, dynamic> ProcedureStepLogic { get; }
        dynamic ProcedureStepLogicArguments { get; }
        dynamic ProcedureStepOutput { get; }
        string ProcedureStepVerboseDescription { get; }
    }

    public interface IProcedureStep : IProcedureStepBase { }

    /// <summary> [public] interface for [restricting a class to a specific user] as [business] entity; this encapsulates [the ISP which restricts a user to solely useful class members].</summary>
    public class ProcedureData() : IProcedureBase
    {
        public List<ProcedureStepData> lasagnaProcedureSteps { get; set; }
    }
    public class ProcedureStepData() : IProcedureStepBase, IProcedureStep, IProcedureStep
    {
        #region Backing field members
        /// <structure-section> Centralization of all foundational data-encapsulating declarations; a sole address for any data-related development.</structure-section>

        // [CONST BACKING FIELD MEMBERS]
        /// <summary> [_private_public_protected_expl_interface_impl_private_] const backing field for [_member_good_title_] internal state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>
        const string DEFAULT_PROCEDURE_VERBOSE_DESCRIPTION = "no desciption given for this process step";

        // [STATIC BACKING FIELD MEMBERS]
        /// <summary> [_private_public_protected_expl_interface_impl_private_] static backing field for [_member_good_title_] internal state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>

        // [INSTANCE BACKING FIELD MEMBERS]
        /// <summary> [_private_public_protected_expl_interface_impl_private_] instance backing field for [_member_good_title_] internal state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>
        private Func<dynamic, dynamic> _procedureStepLogic;
        private dynamic _procedureStepLogicArguments;
        private string _procedureStepVerboseDescription;

        #endregion

        #region Constructors
        #region Static-data constructor member
        /// <structure-section> Encapsulation of all foundational static member initializations via this default static constructor.</structure-section>

        // [STATIC CONSTRUCTOR MEMBER]
        /// <summary> default static constructor handling all static member initializations.</summary>

        // [Initialize backing fields: only initialization, no declaration or processing!]
        #endregion

        #region Instance-data constructor members
        /// <structure-section> Encapsulation of all core instance member initializations via this argumented instance constructor.</structure-section>
        /// <summary> default static constructor handling all static member initializations.</summary>
        static ProcedureStepData()
        {
            // [Initialize backing fields: only initialization, no declaration or processing!]
        }

        // [INSTANCE CONSTRUCTOR MEMBERS]
        /// <summary> argumented instance constructor handling (collectively) all instance member initializations.</summary>
        public ProcedureStepData(Func<dynamic, dynamic> procedureStepLogic, dynamic procedureStepLogicArguments, string procedureStepVerboseDescription = DEFAULT_PROCEDURE_VERBOSE_DESCRIPTION) : this()
        {
            // [Initialize backing fields: only initialization, no declaration or processing!]
            ProcedureStepLogic = procedureStepLogic;
            ProcedureStepLogicArguments = procedureStepLogicArguments;
            ProcedureStepVerboseDescription = procedureStepVerboseDescription;
        }

        #endregion
        #endregion

        #region General property members
        /// <structure-section> Centralization of all core general data-exposing properties; a sole address for any related development.</structure-section>

        // [STATIC GENERAL PROPERTY MEMBERS]
        /// <summary> [_private_public_protected_expl_interface_impl_private_] static property for [_member_good_title_] exposed state; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


        // [INSTANCE GENERAL PROPERTY MEMBERS]
        /// <summary> [private] instance property for [procedure step logic] exposed state; Enabling [this] to [internally exposing the execution logic].</summary>
        private Func<dynamic, dynamic> ProcedureStepLogic 
        { 
            get { return _procedureStepLogic; } 
            set { _procedureStepLogic = value; } 
        }
        /// <summary> [private] instance property for [procedure step logic arguments] exposed state; Enabling [this] to [internally exposing the logic arguments].</summary>
        private dynamic ProcedureStepLogicArguments 
        { 
            get { return _procedureStepLogicArguments; } 
            set { _procedureStepLogicArguments = value; } 
        }
        /// <summary> [public] instance property for [procedure step intent] exposed state; Enabling [anyone] to [exposing the procedure step intent].</summary>
        public string ProcedureStepVerboseDescription 
        { 
            get { return _procedureStepVerboseDescription; } 
            private set { _procedureStepVerboseDescription = value; } 
        }
        /// <summary> [public] instance property for [procedure step output] exposed state; Enabling [anyone] to [exposing the procedure result].</summary>
        public dynamic ProcedureStepOutput
        {
            get { return ProcedureStepLogic(ProcedureStepLogicArguments); }
        }

        #endregion

        #region Implementing business logic
        #region Business Logic members
        /// <structure-section> Centralization of all core business-logic-encapsulating member; a sole address for any related development.</structure-section>

        // [STATIC MAIN BUSINESS-LOGIC MEMBERS]
        /// <summary> [_private_public_protected_expl_interface_impl_private_] static member for [_member_good_title_] feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


        // [INSTANCE MAIN BUSINESS-LOGIC MEMBERS]
        /// <summary> [_private_public_protected_expl_interface_impl_private_] instance member for [_member_good_title_] feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


        #endregion

        #region Utility members
        /// <structure-section> Centralization of all core utility-therefore-business-logic-encapsulating members; a sole address for any related development.</structure-section>

        // [STATIC UTILITY MEMBERS]
        /// <summary> [_private_public_protected_expl_interface_impl_private_] static utility member for [_member_good_title_] utility feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>

        /// <summary> [public] static utility member for [any type to dynamic conversion] utility feature; Enabling [others] to [wrap a specificly-typed function in a dynamically-executionable one].</summary>
        public static Func<dynamic, dynamic> ConvertToDynamicWrapper(Delegate originalFunction)
        {
            #region Define a Method flow
            /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC
            Func<dynamic, dynamic> anyToDynamicTypeConvertedFunction = default;
            Func<dynamic, dynamic> localConvertToDynamicWrapper()
            {
                return new Func<dynamic, dynamic>((dynamic param) =>
                {
                    #region Define a Method flow
                    /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC
                    dynamic anyToDynamicTypeConvertedFunction = default;

                    dynamic LocalConvertToDynamicWrapper()
                    {
                        /// <structure-section> [DEFINE-SEGMENT] DECLARE AND INITIALIZE DATA AND/OR LOGIC
                        object[] argumentList = default;

                        /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES
                        argumentList = ((object[])param);

                        /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE
                        return (dynamic)originalFunction.DynamicInvoke(argumentList);
                    }
                    #endregion

                    #region Process a Method flow
                    /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES
                    anyToDynamicTypeConvertedFunction = LocalConvertToDynamicWrapper();
                    #endregion

                    #region Conclude a Method flow
                    /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE
                    return anyToDynamicTypeConvertedFunction;
                    #endregion
                });
            }
            #endregion

            #region Process a Method flow
            /// <structure-section> [PROCESS-SEGMENT] EMPLOY DEFINED MEMBERS IN PROCESSES
            anyToDynamicTypeConvertedFunction = localConvertToDynamicWrapper();
            #endregion

            #region Conclude a Method flow
            /// <structure-section> [CONCLUDE-SEGMENT] REALISE THE METHOD'S INTENT AND FINALIZE
            return anyToDynamicTypeConvertedFunction;
            #endregion
        }

        // [INSTANCE UTILITY MEMBERS]
        /// <summary> [_private_public_protected_expl_interface_impl_private_] instance utility member for [_member_good_title_] utility feature; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>

        #endregion

        #region Delegate members
        /// <code-structure-section> Centralization of all foundational logic-delegating signatures; a sole address for any delegate-related development.</structure-section>

        // [ DELEGATE MEMBERS]
        /// <summary> [_private_public_protected_expl_interface_impl_private_] delegate for [_member_good_title_] delegate; Enabling [_others_anyone_inheritors_this_internals] to [_CRUD_ _member_intent_].</summary>


        #endregion
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
