namespace AGT.GalacticArchives.Core.Models.Application.Exceptions;

/// <summary>
/// An exception that represents failed validation
/// </summary>
[Serializable]
public class AuthenticationValidationException : Exception
{
    public AuthenticationValidationException()
        : base(nameof(AuthenticationValidationException)) { }

    public AuthenticationValidationException(string message)
        : base(message) { }

    public AuthenticationValidationException(string message, Exception innerException)
        : base(message, innerException) { }
}