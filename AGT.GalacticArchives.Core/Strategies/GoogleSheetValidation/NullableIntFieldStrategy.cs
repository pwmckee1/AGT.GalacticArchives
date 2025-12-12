using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class NullableIntFieldStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
{
    public void Execute(IExecutionContext context)
    {
        if (!string.IsNullOrEmpty(FieldValue))
        {
            string commaStrippedField = FieldValue.Replace(",", string.Empty);
            if (!int.TryParse(commaStrippedField, out _))
            {
                context.Errors.Add(
                    string.Format(
                        ImportResource.InvalidInteger,
                        SheetName,
                        LineNumber,
                        PropertyName));
            }
        }
    }
}