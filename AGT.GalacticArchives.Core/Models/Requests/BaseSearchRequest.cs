using AGT.GalacticArchives.Core.Constants;
using AGT.GalacticArchives.Core.Interfaces.Models;

namespace AGT.GalacticArchives.Core.Models.Requests;

public class BaseSearchRequest : ISearchRequest
{
    private int? _pageSize;

    /// <summary>
    /// Page Number for paginated response
    /// </summary>
    public int PageNumber { get; set; } = BusinessRuleConstants.DefaultPageNumber;

    /// <summary>
    /// Number of elements per page in a paginated response, max is 100 results
    /// </summary>
    public int PageSize
    {
        get => _pageSize ?? BusinessRuleConstants.DefaultPageSize;
        set => _pageSize = Math.Min(value, BusinessRuleConstants.MaxPageSize);
    }

    /// <summary>
    /// Optional order by property
    /// </summary>
    public string? OrderBy { get; set; }
}