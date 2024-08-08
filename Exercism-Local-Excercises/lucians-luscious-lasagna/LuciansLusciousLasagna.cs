using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        /* Define: Declare and Initialise variables */
        // Define-sub: Output Variables
        int output = default;
        // Define-sub: Process Variables
        const int lasagnaCookingTime = 40;

        /* Process: Perform logic on defined variables */
        output = lasagnaCookingTime;

        /* Conclude: Perform the method intent (output data) */
        return output;
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