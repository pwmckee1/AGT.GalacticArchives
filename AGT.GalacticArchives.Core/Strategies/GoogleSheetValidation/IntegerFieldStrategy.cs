using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class IntegerFieldStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
{
    public void Execute(IExecutionContext context)
    {
        if (string.IsNullOrEmpty(FieldValue) ||
            !int.TryParse(FieldValue.Replace(",", string.Empty), out _))
        {
            context.Errors.Add(
                string.Format(
                    GoogleSheetResource.InvalidInteger,
                    SheetName,
                    LineNumber,
                    PropertyName));
        }
    }
}