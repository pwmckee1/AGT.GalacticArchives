namespace AGT.GalacticArchives.Core.Strategies.GoogleSheetValidation;

public abstract class BaseGoogleSheetStrategy(string? fieldValue, int lineNumber, string propertyName, string sheetName)
{
    protected readonly string? FieldValue = fieldValue;
    protected readonly int LineNumber = lineNumber;
    protected readonly string PropertyName = propertyName;
    protected readonly string SheetName = sheetName;
}