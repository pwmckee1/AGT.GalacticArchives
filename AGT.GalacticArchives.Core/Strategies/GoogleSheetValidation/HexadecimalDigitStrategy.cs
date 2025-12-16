using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class HexadecimalDigitStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
{
    public void Execute(IExecutionContext context)
    {
        if (FieldValue!.Length != 4 || !RegexConstants.AxisHexRegexPattern().IsMatch(FieldValue!))
        {
            context.Errors.Add(
                string.Format(
                    ImportResource.InvalidQuadrant,
                    SheetName,
                    LineNumber,
                    PropertyName));
        }
    }
}