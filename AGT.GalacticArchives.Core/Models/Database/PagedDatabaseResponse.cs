namespace AGT.GalacticArchives.Core.Models.Database;

public class PagedDatabaseResponse
{
    public int PageNumber { get; set; }

    public int PageSize { get; set; }

    public long TotalRecords { get; set; }

    public long TotalPages { get; set; }

    public HashSet<Dictionary<string, object>> Response { get; set; } = [];
}