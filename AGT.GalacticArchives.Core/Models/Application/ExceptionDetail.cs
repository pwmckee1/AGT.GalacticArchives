namespace AGT.GalacticArchives.Core.Models.Application;

public class ExceptionDetail
{
    public ExceptionDetail(string? message, string? stackTrace)
    {
        Message = message;
        StackTrace = stackTrace;
    }

    public string? Message { get; set; }

    public string? StackTrace { get; set; }

    public ExceptionDetail? InnerException { get; set; }
}