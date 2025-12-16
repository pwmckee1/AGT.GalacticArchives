namespace AGT.GalacticArchives.Core.Models.Application;

public class ExceptionDetail(string? message, string? stackTrace)
{
    public string? Message { get; set; } = message;

    public string? StackTrace { get; set; } = stackTrace;

    public ExceptionDetail? InnerException { get; set; }
}