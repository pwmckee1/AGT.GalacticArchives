using System.Globalization;
using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class NullableDateTimeStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
{
    public void Execute(IExecutionContext context)
    {
        if (!string.IsNullOrEmpty(FieldValue) &&
            !DateTimeOffset.TryParseExact(
                FieldValue,
                BusinessRuleConstants.ValidDateTimeFormats,
                DateTimeFormatInfo.InvariantInfo,
                DateTimeStyles.None,
                out _))
        {
            context.Errors.Add(
                string.Format(
                    ImportResource.InvalidDateTime,
                    SheetName,
                    LineNumber,
                    PropertyName));
        }
    }
}