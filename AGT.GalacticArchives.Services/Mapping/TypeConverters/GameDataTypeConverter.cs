using AGT.GalacticArchives.Core.Extensions;
using AGT.GalacticArchives.Core.Models.GameData;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Mapping.TypeConverters;

public class GameDataTypeConverter :
    ITypeConverter<Dictionary<string, object?>, Galaxy>,
    ITypeConverter<Dictionary<string, object>, Region>,
    ITypeConverter<Dictionary<string, object>, StarSystem>,
    ITypeConverter<Dictionary<string, object>, Planet>,
    ITypeConverter<Dictionary<string, object>, Starship>,
    ITypeConverter<Dictionary<string, object>, PlayerBase>,
    ITypeConverter<Dictionary<string, object>, Fauna>,
    ITypeConverter<Dictionary<string, object>, MultiTool>,
    ITypeConverter<Dictionary<string, object>, PointOfInterest>,
    ITypeConverter<Dictionary<string, object>, Settlement>
{
    public Galaxy Convert(Dictionary<string, object?> source, Galaxy destination, ResolutionContext context)
    {
        return source!.ConvertDictionaryToObject<Galaxy>();
    }

    public Region Convert(Dictionary<string, object> source, Region destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<Region>();
    }

    public StarSystem Convert(Dictionary<string, object> source, StarSystem destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<StarSystem>();
    }

    public Planet Convert(Dictionary<string, object> source, Planet destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<Planet>();
    }

    public Starship Convert(Dictionary<string, object> source, Starship destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<Starship>();
    }

    public PlayerBase Convert(Dictionary<string, object> source, PlayerBase destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<PlayerBase>();
    }

    public Fauna Convert(Dictionary<string, object> source, Fauna destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<Fauna>();
    }

    public MultiTool Convert(Dictionary<string, object> source, MultiTool destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<MultiTool>();
    }

    public PointOfInterest Convert(Dictionary<string, object> source, PointOfInterest destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<PointOfInterest>();
    }

    public Settlement Convert(Dictionary<string, object> source, Settlement destination, ResolutionContext context)
    {
        return source.ConvertDictionaryToObject<Settlement>();
    }
}