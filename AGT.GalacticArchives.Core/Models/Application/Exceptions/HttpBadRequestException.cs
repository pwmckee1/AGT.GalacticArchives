using Microsoft.AspNetCore.Http;

namespace AGT.GalacticArchives.Core.Models.Application.Exceptions;

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