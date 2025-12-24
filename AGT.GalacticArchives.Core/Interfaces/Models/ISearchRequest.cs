namespace AGT.GalacticArchives.Core.Interfaces.Models;

public interface ISearchRequest
{
    /// <summary>
    /// Page Number for paginated response
    /// </summary>
    int PageNumber { get; set; }

    /// <summary>
    /// Number of elements per page in a paginated response, max is 100 results
    /// </summary>
    int PageSize { get; set; }

    /// <summary>
    /// Optional order by property
    /// </summary>
    string? OrderBy { get; set; }
}