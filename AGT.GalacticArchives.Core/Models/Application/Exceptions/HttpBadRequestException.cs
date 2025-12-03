namespace AGT.GalacticArchives.Core.Models.Application.Exceptions;

using Microsoft.AspNetCore.Http;

public class HttpBadRequestException : Exception
{
    public HttpBadRequestException(string message)
        : base(message)
    {
    }

    public HttpBadRequestException(string message, Exception inner)
        : base(message, inner)
    {
    }

    public int StatusCode { get; } = StatusCodes.Status400BadRequest;
}