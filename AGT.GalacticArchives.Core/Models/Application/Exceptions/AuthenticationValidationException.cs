namespace AGT.GalacticArchives.Core.Models.Application.Exceptions;

/// <summary>
/// An exception that represents failed validation
/// </summary>
[Serializable]
#pragma warning disable S3925
public class AuthenticationValidationException : Exception
#pragma warning restore S3925
{
    public AuthenticationValidationException()
        : base(nameof(AuthenticationValidationException))
    {
    }

    public AuthenticationValidationException(string message)
        : base(message)
    {
    }

    public AuthenticationValidationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}