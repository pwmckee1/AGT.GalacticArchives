using System.Diagnostics.CodeAnalysis;
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

    [SuppressMessage("Performance", "CA1822:Mark members as static")]
    public int StatusCode => StatusCodes.Status400BadRequest;
}