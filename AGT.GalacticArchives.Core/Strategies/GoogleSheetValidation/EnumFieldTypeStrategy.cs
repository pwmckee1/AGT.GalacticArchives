using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class EnumFieldTypeStrategy<T>(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
    where T : struct, Enum
{
    public void Execute(IExecutionContext context)
    {
        var validValues = EnumExtensions.GetDescriptions<T>();

        if (!validValues.Contains(FieldValue!))
        {
            context.Errors.Add(
                string.Format(
                    ImportResource.InvalidFieldEnum,
                    SheetName,
                    LineNumber,
                    PropertyName));
        }
    }
}