using AGT.GalacticArchives.Core.Enums;
using AGT.GalacticArchives.Core.Models.GameData;
using AutoMapper;

namespace AGT.GalacticArchives.Services.Mapping.TypeConverters;

public class GameDataTypeConverter :
    ITypeConverter<Dictionary<string, object>, Galaxy>,
    ITypeConverter<Dictionary<string, object>, Region>,
    ITypeConverter<Dictionary<string, object>, StarSystem>
{
    public StarSystem Convert(Dictionary<string, object> source, StarSystem destination, ResolutionContext context)
    {
        return new StarSystem
        {
            StarSystemId = (Guid)source[nameof(StarSystem.StarSystemId)],
            Name = (string)source[nameof(StarSystem.Name)],
            AdminNotes = (string?)source[nameof(StarSystem.AdminNotes)],
            DataQualityCheck = (string?)source[nameof(StarSystem.DataQualityCheck)],
            OriginalSystemName = (string?)source[nameof(StarSystem.OriginalSystemName)],
            GalacticCoordinates = (string)source[nameof(StarSystem.GalacticCoordinates)],
            GlyphCode = (string)source[nameof(StarSystem.GlyphCode)]!,
            PlanetOfInterestId = (Guid?)source[nameof(StarSystem.PlanetOfInterestId)],
            RegionId = (Guid)source[nameof(StarSystem.RegionId)],
            SurveyorName = (string?)source[nameof(StarSystem.SurveyorName)],
            DiscoveredBy = (string?)source[nameof(StarSystem.DiscoveredBy)],
            SpecialInterest = (string?)source[nameof(StarSystem.SpecialInterest)],
            CivilizedBy = (string?)source[nameof(StarSystem.CivilizedBy)],
            StarCategory = (string?)source[nameof(StarSystem.StarCategory)],
            Color = (string?)source[nameof(StarSystem.Color)],
            GameRelease = (string?)source[nameof(StarSystem.GameRelease)],
            StarCount = (int?)source[nameof(StarSystem.StarCount)],
            NumberOfPlanets = (int?)source[nameof(StarSystem.NumberOfPlanets)],
            NumberOfMoons = (int?)source[nameof(StarSystem.NumberOfMoons)],
            LightYearsFromCenter = (int?)source[nameof(StarSystem.LightYearsFromCenter)],
            Buy = (float?)source[nameof(StarSystem.Buy)],
            Sell = (float?)source[nameof(StarSystem.Sell)],
            PlatformType = (string?)source[nameof(StarSystem.PlatformType)],
            GameModeType = (string?)source[nameof(StarSystem.GameModeType)],
            Faction = (string?)source[nameof(StarSystem.Faction)],
            EconomyType = (string?)source[nameof(StarSystem.EconomyType)],
            WealthType = (string?)source[nameof(StarSystem.WealthType)],
            ConflictType = (string?)source[nameof(StarSystem.ConflictType)],
            IsGiantSystem = (bool)source[nameof(StarSystem.IsGiantSystem)],
            IsDissonant = (bool)source[nameof(StarSystem.IsDissonant)],
            HasWater = (bool)source[nameof(StarSystem.HasWater)],
            DiscoveryDate = (DateTime?)source[nameof(StarSystem.DiscoveryDate)],
            SurveyDate = (DateTime?)source[nameof(StarSystem.SurveyDate)],
        };
    }

    public Galaxy Convert(Dictionary<string, object> source, Galaxy destination, ResolutionContext context)
    {
        return new Galaxy
        {
            GalaxyId = (Guid)source[nameof(Galaxy.GalaxyId)]!,
            Sequence = (int)source[nameof(Galaxy.Sequence)]!,
            Name = (string)source[nameof(Galaxy.Name)]!,
        };
    }

    public Region Convert(Dictionary<string, object> source, Region destination, ResolutionContext context)
    {
        return new Region
        {
            RegionId = (Guid)source[nameof(Region.RegionId)],
            GalaxyId = (Guid)source[nameof(Region.GalaxyId)],
            Quadrant = (GalaxyQuadrants?)source[nameof(Region.Quadrant)],
            AutoLatestSurvey = (DateTime?)source[nameof(Region.AutoLatestSurvey)],
            DocSequence = (int)source[nameof(Region.DocSequence)],
            RegionAge = (float?)source[nameof(Region.CivilizedSpaceNotes)],
            Name = (string)source[nameof(Region.Name)]!,
            CivilizedBy = (string?)source[nameof(Region.CivilizedBy)],
            Coordinates = (string?)source[nameof(Region.Coordinates)],
            GameRelease = (string?)source[nameof(Region.GameRelease)],
            EarliestKnownSurveyorId = (string?)source[nameof(Region.EarliestKnownSurveyorId)],
            LatestKnownSurveyorId = (string?)source[nameof(Region.LatestKnownSurveyorId)],
            SummaryNotes = (string?)source[nameof(Region.SummaryNotes)],
            LocationNotes = (string?)source[nameof(Region.LocationNotes)],
            AdditionalNotes = (string?)source[nameof(Region.AdditionalNotes)],
            CivilizedSpaceNotes = (string?)source[nameof(Region.CivilizedSpaceNotes)],
            LowestKnownPhantomSystem = (string?)source[nameof(Region.LowestKnownPhantomSystem)],
            WikiLink = (string?)source[nameof(Region.WikiLink)],
            ExternalLink1 = (string?)source[nameof(Region.ExternalLink1)],
            VideoLink1 = (string?)source[nameof(Region.VideoLink1)],
            LightYearsFromCenter = (int?)source[nameof(Region.LightYearsFromCenter)],
        };
    }
}