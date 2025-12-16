namespace AGT.GalacticArchives.Core.Models.Application;

public class MessageResponse<T>
{
    /// <summary>
    /// Response payload
    /// </summary>
    public T Response { get; set; } = default!;

    /// <summary>
    /// Error messages if errors occur
    /// </summary>
    public HashSet<object> Messages { get; set; } = [];
}