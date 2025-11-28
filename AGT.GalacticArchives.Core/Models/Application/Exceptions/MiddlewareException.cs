namespace AGT.GalacticArchives.Core.Models.Application.Exceptions;

public class MiddlewareException : Exception
{
    public MiddlewareException(object url, object userId, object? requestBody, object userAgent, ExceptionDetail? exceptionDetail)
    {
        Url = url;
        UserId = userId;
        RequestBody = requestBody;
        UserAgent = userAgent;
        ExceptionDetail = exceptionDetail;
    }

    public object Url { get; set; }

    public object UserId { get; set; }

    public object? RequestBody { get; set; }

    public object UserAgent { get; set; }

    public ExceptionDetail? ExceptionDetail { get; set; }
}