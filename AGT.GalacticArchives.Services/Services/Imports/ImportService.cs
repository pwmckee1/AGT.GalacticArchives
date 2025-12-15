using System.Globalization;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Globalization;
using AGT.GalacticArchives.Services.Interfaces.Services;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;

namespace AGT.GalacticArchives.Services.Services.Imports;

public abstract class ImportService<T>(IEnumerable<IImportValidationHandler> importValidationHandlers) : IImportService
{
    protected HashSet<string> Errors = [];

    protected abstract string SheetName { get; }

    protected abstract Type CsvMapType { get; }

    public virtual async Task ImportFormFileAsync(IFormFile form, CancellationToken ct = default)
    {
        var importData = await ValidateFileAsync(form, ct);
        await ProcessValidatedDataAsync(importData, ct);
    }

    public async Task<HashSet<T>> ValidateFileAsync(IFormFile form, CancellationToken ct = default)
    {
        if (!form.FileName.Contains(SheetName))
        {
            throw new ArgumentException(string.Format(ImportResource.InvalidFormFile, SheetName, form.FileName));
        }

        var importData = await GetRecordsFromCsvFileAsync(form.OpenReadStream(), ct);
        Errors = ValidateRecords(importData);

        return importData;
    }

    protected abstract Task ProcessValidatedDataAsync(HashSet<T> importData, CancellationToken ct = default);

    protected virtual HashSet<string> ValidateRecords<THandler>(HashSet<THandler> importRequest)
    {
        var handler = importValidationHandlers.SingleOrDefault(h => h.CanHandle<THandler>());
        return handler != null ? handler.Handle(importRequest, Errors) : [];
    }

    protected async Task<HashSet<T>> GetRecordsFromCsvFileAsync(Stream stream, CancellationToken ct)
    {
        try
        {
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture) { MissingFieldFound = null };

            using var streamReader = new StreamReader(stream);
            using var csvReader = new CsvReader(streamReader, csvConfig);

            csvReader.Context.RegisterClassMap(CsvMapType);

            await ValidateHeaderAsync(csvReader, ct);

            var records = csvReader.GetRecords<T>();
            return records.ToHashSet();
        }
        catch (Exception e)
        {
            throw new ArgumentException(string.Format(ImportResource.UnableToImportError, SheetName, e.Message));
        }
    }

    protected async Task ValidateHeaderAsync(CsvReader csvReader, CancellationToken ct)
    {
        await csvReader.ReadAsync();
        csvReader.ReadHeader();
        var contextReader = csvReader.Context.Reader;
        if (contextReader != null)
        {
            string[]? headerRow = csvReader.Context.Reader!.HeaderRecord;
            var missingHeaders = new HashSet<string>();
            var properties = typeof(T).GetProperties().Select(p => p.GetDescription()).ToHashSet();

            foreach (string propertyName in properties)
            {
                // Interrupt validation process if cancelled
                ct.ThrowIfCancellationRequested();

                if (!headerRow.Contains(propertyName))
                {
                    missingHeaders.Add(propertyName);
                }
            }

            if (missingHeaders.Count > 0)
            {
                Errors.Add(
                    string.Format(ImportResource.MissingSheetHeader, SheetName, string.Join(", ", missingHeaders)));
            }
        }
    }
}