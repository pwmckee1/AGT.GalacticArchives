using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class NullableBoolFieldStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
{
    public void Execute(IExecutionContext context)
    {
        if (!bool.TryParse(FieldValue, out _))
        {
            context.Errors.Add(
                string.Format(
                    GoogleSheetResource.RequiredFieldMissingError,
                    SheetName,
                    LineNumber,
                    PropertyName));
        }
    }
}