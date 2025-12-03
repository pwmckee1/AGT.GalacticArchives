namespace AGT.GalacticArchives.Core.Models.Application.Exceptions;

public class MiddlewareException(
    object url,
    object userId,
    object? requestBody,
    object userAgent,
    ExceptionDetail? exceptionDetail) : Exception
{
    public object Url { get; set; } = url;

    public object UserId { get; set; } = userId;

    public object? RequestBody { get; set; } = requestBody;

    public object UserAgent { get; set; } = userAgent;

    public ExceptionDetail? ExceptionDetail { get; set; } = exceptionDetail;
}