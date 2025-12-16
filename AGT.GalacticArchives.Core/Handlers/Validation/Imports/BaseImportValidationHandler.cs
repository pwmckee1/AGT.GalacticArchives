using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Strategies;

namespace AGT.GalacticArchives.Core.Handlers.Validation.Imports;

public abstract class BaseImportValidationHandler
{
    protected int LineNumber = BusinessRuleConstants.StartingImportSheetLineNumber;

    protected abstract string SheetName { get; }

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