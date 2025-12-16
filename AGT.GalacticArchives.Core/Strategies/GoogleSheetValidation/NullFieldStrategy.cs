using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class NullFieldStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
{
    public void Execute(IExecutionContext context)
    {
        if (string.IsNullOrEmpty(FieldValue))
        {
            context.Errors.Add(
                string.Format(
                    ImportResource.RequiredFieldMissingError,
                    SheetName,
                    LineNumber,
                    PropertyName));
        }
    }
}