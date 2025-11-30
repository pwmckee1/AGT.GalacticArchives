using AGT.GalacticArchives.Core.Models.GameData;
using AGT.GalacticArchives.Services.Mapping.TypeConverters;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Mapping;

public class GameDataMaps : Profile
{
    public GameDataMaps()
    {
        CreateMap<Dictionary<string, object?>, Galaxy>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object?>, Region>()
            .ConvertUsing<GameDataTypeConverter>()
            ;

        CreateMap<Dictionary<string, object?>, StarSystem>()
            .ConvertUsing<GameDataTypeConverter>()
            ;
    }
}