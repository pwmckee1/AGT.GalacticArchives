using System.Globalization;
using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Interfaces.Handlers;
using AGT.GalacticArchives.Core.Interfaces.Models;
using AGT.GalacticArchives.Globalization;
using AGT.GalacticArchives.Services.Interfaces.Services;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;

namespace AGT.GalacticArchives.Services.Services.Imports;

public abstract class ImportService<T>(
    IEnumerable<IImportValidationHandler> importValidationHandlers) : IImportService
{
    protected HashSet<string> Errors = [];

    protected abstract string SheetName { get; }

    protected abstract Type CsvMapType { get; }

    public virtual async Task ImportFormFileAsync(IFormFile form)
    {
        var importData = await ValidateFileAsync(form);
        await ProcessValidatedDataAsync(importData);
    }

    public async Task<HashSet<T>> ValidateFileAsync(IFormFile form)
    {
        if (!form.Name.Contains(SheetName))
        {
            throw new ArgumentException(string.Format(ImportResource.InvalidFormFile, SheetName, form.Name));
        }

        var importData = await GetRecordsFromCsvFileAsync(form.OpenReadStream());
        Errors = ValidateRecords(importData);

        return importData;
    }

    protected abstract Task ProcessValidatedDataAsync(HashSet<T> importData);

    protected virtual HashSet<string> ValidateRecords<THandler>(HashSet<THandler> importRequest)
    {
        var handler = importValidationHandlers.SingleOrDefault(h => h.CanHandle<THandler>());
        return handler != null ? handler.Handle(importRequest, Errors) : [];
    }

    protected async Task<HashSet<T>> GetRecordsFromCsvFileAsync(Stream stream)
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture) { MissingFieldFound = null };

        using var streamReader = new StreamReader(stream);
        using var csvReader = new CsvReader(streamReader, csvConfig);

        csvReader.Context.RegisterClassMap(CsvMapType);

        await ValidateHeaderAsync(csvReader);

        var records = csvReader.GetRecords<T>();
        return records.ToHashSet();
    }

    protected async Task ValidateHeaderAsync(CsvReader csvReader)
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
                if (!headerRow.Contains(propertyName))
                {
                    missingHeaders.Add(propertyName);
                }
            }

            if (missingHeaders.Count > 0)
            {
                Errors.Add(
                    string.Format(
                        ImportResource.MissingSheetHeader,
                        SheetName,
                        string.Join(", ", missingHeaders)));
            }
        }
    }
}