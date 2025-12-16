using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class GalacticCoordinateStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
{
    public void Execute(IExecutionContext context)
    {
        if (string.IsNullOrEmpty(FieldValue) || RegexConstants.GalacticCoordinateRegexPattern().IsMatch(FieldValue))
        {
            context.Errors.Add(
                string.Format(
                    ImportResource.InvalidGalacticCoordinate,
                    SheetName,
                    LineNumber));
        }
    }
}