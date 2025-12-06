using AGT.GalacticArchives.Core.Strategies;

namespace AGT.GalacticArchives.Core.Handlers;

public abstract class BaseValidationHandler
{
    protected static void ValidateStrategies(HashSet<IExecutionStrategy> strategies, HashSet<string> errors)
    {
        var validationContext = ValidationContext.CreateContext(strategies);
        validationContext.ExecuteAll();
        AggregateErrors(validationContext, errors);
    }

    private static void AggregateErrors(IExecutionContext validationContext, HashSet<string> errors)
    {
        foreach (string error in validationContext.Errors)
        {
            errors.Add(error);
        }
    }
}