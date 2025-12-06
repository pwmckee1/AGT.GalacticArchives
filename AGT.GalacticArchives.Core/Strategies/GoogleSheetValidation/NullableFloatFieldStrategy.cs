using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class NullableFloatFieldStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
{
    public void Execute(IExecutionContext context)
    {
        if (!string.IsNullOrEmpty(FieldValue) && !float.TryParse(FieldValue, out _))
        {
            context.Errors.Add(
                string.Format(
                    GoogleSheetResource.InvalidFloat,
                    SheetName,
                    LineNumber,
                    PropertyName));
        }
    }
}