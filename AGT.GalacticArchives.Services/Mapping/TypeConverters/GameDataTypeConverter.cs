using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.GameData;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Mapping.TypeConverters;

public class GameDataTypeConverter :
    ITypeConverter<Dictionary<string, object?>, Galaxy>,
    ITypeConverter<Dictionary<string, object?>, Region>,
    ITypeConverter<Dictionary<string, object?>, StarSystem>,
    ITypeConverter<Dictionary<string, object?>, Planet>
{
    public Galaxy Convert(Dictionary<string, object?> source, Galaxy destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<Galaxy>();
    }

    public Region Convert(Dictionary<string, object?> source, Region destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<Region>();
    }

    public StarSystem Convert(Dictionary<string, object?> source, StarSystem destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<StarSystem>();
    }

    public Planet Convert(Dictionary<string, object?> source, Planet destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<Planet>();
    }
}