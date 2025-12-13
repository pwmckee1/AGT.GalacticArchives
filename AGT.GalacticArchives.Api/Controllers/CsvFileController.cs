using System.Collections;
using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using HeyRed.Mime;
using Microsoft.AspNetCore.Mvc;

namespace AGT.GalacticArchives.Controllers;

public abstract class CsvFileController : ControllerBase
{
    protected static async Task<FileStreamResult> File<T>(HashSet<T> data, ClassMap? map = null, string fileDownloadName = "export.csv")
    {
        // The memory and stream writer streams are not wrapped in using statements intentionally
        // The streams will be disposed of too early if wrapped
        var stream = new MemoryStream();
        TextWriter writer = new StreamWriter(stream, Encoding.UTF8);
        var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
        {
            ShouldQuote = _ => true,
        };
        var csv = new CsvWriter(writer, csvConfig);
        try
        {
            if (map != null)
            {
                csv.Context.RegisterClassMap(map);
            }

            if (typeof(T).IsInterface)
            {
                // if typeof(T) is an interface, CsvHelper cannot properly write the records
                await csv.WriteRecordsAsync(data as IEnumerable);
            }
            else
            {
                await csv.WriteRecordsAsync(data);
            }

            await writer.FlushAsync();

            return CustomFileResult(stream, fileDownloadName);
        }
        catch (Exception)
        {
            await csv.DisposeAsync();
            await writer.DisposeAsync();
            await stream.DisposeAsync();
            throw;
        }
    }

    protected static FileStreamResult CustomFileResult(Stream fileStream, string fileDownloadName = "export.csv")
    {
        string contentType = MimeTypesMap.GetMimeType(fileDownloadName);

        fileStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(fileStream, contentType) { FileDownloadName = fileDownloadName };
    }
}