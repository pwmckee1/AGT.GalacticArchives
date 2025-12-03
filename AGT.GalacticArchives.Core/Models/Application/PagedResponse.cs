namespace AGT.GalacticArchives.Core.Models.Application;

public class PagedResponse<T> : MessageResponse<HashSet<T>>
{
    /// <summary>
    /// Current page number in paginated response
    /// </summary>
    public int PageNumber { get; set; }

    /// <summary>
    /// Number of elements per page in paginated response
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    /// Total pages in paginated response
    /// </summary>
    public int TotalPages { get; set; }

    /// <summary>
    /// Total elements in all pages of paginated response
    /// </summary>
    public int TotalRecords { get; set; }
}