using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.Enums;
using AGT.GalacticArchives.Globalization;

namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public class GalacticQuadrantStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
    : BaseGoogleSheetStrategy(fieldValue, lineNumber, propertyName, sheetName), IExecutionStrategy
{
    public void Execute(IExecutionContext context)
    {
        var validQuadrants = EnumExtensions.GetDescriptions<GalacticQuadrants>();
        if (!validQuadrants.Contains(FieldValue!))
        {
            context.Errors.Add(
                string.Format(
                    GoogleSheetResource.InvalidQuadrant,
                    SheetName,
                    LineNumber));
        }
    }
}