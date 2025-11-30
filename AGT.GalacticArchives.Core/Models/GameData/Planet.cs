namespace AGT.GalacticArchives.Core.Models.GameData;

public class Planet
{
    public Guid EntityId => PlanetId;

    public Guid PlanetId { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public string NormalizedName => Name.ToUpperInvariant();

    public string? PlanetNameAllPlatforms { get; set; }

    public string? AdminNotes { get; set; }

    public string? DataQualityCheck { get; set; }

    public string? OriginalPlanetName { get; set; }

    public string? PlanetMoonMatch { get; set; }

    public string? PlanetOrMoon { get; set; }

    public string? RingsOrGiant  { get; set; }

    public int? PlanetIdInSystem { get; set; }

    public string? BiomeType { get; set; }

    public string? BiomeDescription { get; set; }

    public bool? IsInfected { get; set; }

    public string? Terrain { get; set; }

    public string? TypeOfLand { get; set; }

    public string? ArchetypeOfLand { get; set; }

    public string? Weather { get; set; }

    public string? ExtremeWeatherExcludingMegaExotic { get; set; }

    public string? ExtremeWeatherInludingMegaExotic { get; set; }

    public string? PrimaryResource1 { get; set; }

    public string? PrimaryResource2 { get; set; }

    public string? PrimaryResource3 { get; set; }

    public string? BiomeResource { get; set; }

    public string? AtmosphereResource { get; set; }

    public string? AtmosphereDaytimeColor { get; set; }

    public string? SpecialA { get; set; }

    public string? ExtrasA { get; set; }

    public string? ExtrasB { get; set; }

    public string? ExtrasC { get; set; }

    public string? Glitches { get; set; }

    public string? AssignedRawIngredient { get; set; }

    public HashSet<string?> RawIngredients { get; set; } = [];

    public string? Sentinel { get; set; }

    public string? Flora { get; set; }

    public string? Fauna { get; set; }

    public int? NumberOfFauna { get; set; }

    public string? Mode { get; set; }

    public string? CivilizedBy { get; set; }

    public string? DiscovererGamertag { get; set; }

    public string? DiscoveredLinkOnWiki { get; set; }

    public string? DiscoveryDate { get; set; }

    public string? SurveyorGamertag { get; set; }

    public string? SurveyDate { get; set; }

    public string? DiscoveryPlatform { get; set; }

    public string? SurveyReleaseEra { get; set; }

    public string? SummaryInfo { get; set; }

    public string? AdditionalNotes { get; set; }

    public string? DayTemp { get; set; }

    public string? DayRadiation { get; set; }

    public string? DayToxic { get; set; }

    public string? NightTemp { get; set; }

    public string? DayStormTemp { get; set; }

    public string? DayStormRadiation { get; set; }

    public string? DayStormToxic { get; set; }

    public string? NightStormTemp { get; set; }

    public string? UndergroundDayTemp { get; set; }

    public string? UndergroundDayRadiation { get; set; }

    public string? UndergroundDayToxic { get; set; }

    public string? UndergroundNightTemp { get; set; }

    public string? UnderwaterDayTemp { get; set; }

    public string? UnderwaterDayRadiation { get; set; }

    public string? UnderwaterDayToxic { get; set; }

    public string? UnderwaterNightTemp { get; set; }

    public string? UnderwaterDayStormTemp { get; set; }

    public string? UnderwaterDayStormRadiation { get; set; }

    public string? UnderwaterDayStormToxic { get; set; }

    public string? UnderwaterNightStormTemp { get; set; }

    public string? UndergroundDayStormTemp { get; set; }

    public string? UndergroundDayStormRadiation { get; set; }

    public string? UndergroundDayStormToxic { get; set; }

    public string? UndergroundNightStormTemp { get; set; }

    public string? AgeOfPlanetInBillionsOfYears { get; set; }

    public string? AtmosphereGas1 { get; set; }

    public string? AtmosphereGasPercentage1 { get; set; }

    public string? AtmosphereGas2 { get; set; }

    public string? AtmosphereGasPercentage2 { get; set; }

    public string? PrimaryCoreElement { get; set; }

    public string? Geology { get; set; }

    public string? OtherNotes { get; set; }

    public bool? HasSandworms { get; set; }

    public string? WikiLink { get; set; }

    public string? PortalRepository { get; set; }

    public string? ExternalLink1 { get; set; }

    public string? ExternalLink2 { get; set; }

    public string? Garden { get; set; }

    public int? DocumentSequence { get; set; }

    public string? PlanetGlyphs { get; set; }

    public string? ResearchTeam { get; set; }

    public string? PlanetOrMoonAddedInOrigins { get; set; }

    public string? LegacyPCPlanetName { get; set; }

    public string? LegacyPCDiscoveryEra { get; set; }

    public string? LegacyPCDiscoverersGamerTagName { get; set; }

    public string? LegacyPCDiscoveryDate { get; set; }

    public string? LegacyPSPlanetName { get; set; }

    public string? LegacyPSDiscoveryEra { get; set; }

    public string? LegacyPSDiscoverersGamerTagName { get; set; }

    public string? LegacyPSDiscoveryDate { get; set; }

    public string? LegacyXboxPlanetName { get; set; }

    public string? LegacyXboxDiscoveryEra { get; set; }

    public string? LegacyXboxDiscoverersGamerTagName { get; set; }

    public string? LegacyXboxDiscoveryDate { get; set; }

    public string? HistoricalPlanetNameReset { get; set; }

    public string? HistoricalPlanetNamePlatform { get; set; }

    public string? HistoricalPlanetNameLastKnownEra { get; set; }

    public string? HistoricalPlanetDiscoverCreditBeforeReset { get; set; }

    public string? LegacyWikiLinkPC { get; set; }

    public string? LegacyWikiLinkPS { get; set; }

    public string? LegacyWikiLinkXbox { get; set; }

    public string? LegacyWikiLinkOther { get; set; }

    public string? GameVersionNumberForPage { get; set; }

    public int? DocSeqCheck { get; set; }

    public Guid? StarSystemId { get; set; }

    public StarSystem? StarSystem { get; set; }

    // TODO Replace this with Reflection
    public Dictionary<string, object?> ToDictionary()
    {
        return new Dictionary<string, object?>
        {
            { nameof(PlanetId), PlanetId.ToString() },
            { nameof(Name), Name },
            { nameof(NormalizedName), NormalizedName },
            { nameof(PlanetNameAllPlatforms), PlanetNameAllPlatforms },
            { nameof(AdminNotes), AdminNotes },
            { nameof(DataQualityCheck), DataQualityCheck },
            { nameof(OriginalPlanetName), OriginalPlanetName },
            { nameof(PlanetMoonMatch), PlanetMoonMatch },
            { nameof(PlanetOrMoon), PlanetOrMoon },
            { nameof(RingsOrGiant), RingsOrGiant },
            { nameof(PlanetIdInSystem), PlanetIdInSystem },
            { nameof(BiomeType), BiomeType },
            { nameof(BiomeDescription), BiomeDescription },
            { nameof(IsInfected), IsInfected },
            { nameof(Terrain), Terrain },
            { nameof(TypeOfLand), TypeOfLand },
            { nameof(ArchetypeOfLand), ArchetypeOfLand },
            { nameof(Weather), Weather },
            { nameof(ExtremeWeatherExcludingMegaExotic), ExtremeWeatherExcludingMegaExotic },
            { nameof(ExtremeWeatherInludingMegaExotic), ExtremeWeatherInludingMegaExotic },
            { nameof(PrimaryResource1), PrimaryResource1 },
            { nameof(PrimaryResource2), PrimaryResource2 },
            { nameof(PrimaryResource3), PrimaryResource3 },
            { nameof(BiomeResource), BiomeResource },
            { nameof(AtmosphereResource), AtmosphereResource },
            { nameof(AtmosphereDaytimeColor), AtmosphereDaytimeColor },
            { nameof(SpecialA), SpecialA },
            { nameof(ExtrasA), ExtrasA },
            { nameof(ExtrasB), ExtrasB },
            { nameof(ExtrasC), ExtrasC },
            { nameof(Glitches), Glitches },
            { nameof(AssignedRawIngredient), AssignedRawIngredient },
            { nameof(RawIngredients), RawIngredients },
            { nameof(Sentinel), Sentinel },
            { nameof(Flora), Flora },
            { nameof(Fauna), Fauna },
            { nameof(NumberOfFauna), NumberOfFauna },
            { nameof(Mode), Mode },
            { nameof(CivilizedBy), CivilizedBy },
            { nameof(DiscovererGamertag), DiscovererGamertag },
            { nameof(DiscoveredLinkOnWiki), DiscoveredLinkOnWiki },
            { nameof(DiscoveryDate), DiscoveryDate },
            { nameof(SurveyorGamertag), SurveyorGamertag },
            { nameof(SurveyDate), SurveyDate },
            { nameof(DiscoveryPlatform), DiscoveryPlatform },
            { nameof(SurveyReleaseEra), SurveyReleaseEra },
            { nameof(SummaryInfo), SummaryInfo },
            { nameof(AdditionalNotes), AdditionalNotes },
            { nameof(DayTemp), DayTemp },
            { nameof(DayRadiation), DayRadiation },
            { nameof(DayToxic), DayToxic },
            { nameof(NightTemp), NightTemp },
            { nameof(DayStormTemp), DayStormTemp },
            { nameof(DayStormRadiation), DayStormRadiation },
            { nameof(DayStormToxic), DayStormToxic },
            { nameof(NightStormTemp), NightStormTemp },
            { nameof(UndergroundDayTemp), UndergroundDayTemp },
            { nameof(UndergroundDayRadiation), UndergroundDayRadiation },
            { nameof(UndergroundDayToxic), UndergroundDayToxic },
            { nameof(UndergroundNightTemp), UndergroundNightTemp },
            { nameof(UnderwaterDayTemp), UnderwaterDayTemp },
            { nameof(UnderwaterDayRadiation), UnderwaterDayRadiation },
            { nameof(UnderwaterDayToxic), UnderwaterDayToxic },
            { nameof(UnderwaterNightTemp), UnderwaterNightTemp },
            { nameof(UnderwaterDayStormTemp), UnderwaterDayStormTemp },
            { nameof(UnderwaterDayStormRadiation), UnderwaterDayStormRadiation },
            { nameof(UnderwaterDayStormToxic), UnderwaterDayStormToxic },
            { nameof(UnderwaterNightStormTemp), UnderwaterNightStormTemp },
            { nameof(UndergroundDayStormTemp), UndergroundDayStormTemp },
            { nameof(UndergroundDayStormRadiation), UndergroundDayStormRadiation },
            { nameof(UndergroundDayStormToxic), UndergroundDayStormToxic },
            { nameof(UndergroundNightStormTemp), UndergroundNightStormTemp },
            { nameof(AgeOfPlanetInBillionsOfYears), AgeOfPlanetInBillionsOfYears },
            { nameof(AtmosphereGas1), AtmosphereGas1 },
            { nameof(AtmosphereGasPercentage1), AtmosphereGasPercentage1 },
            { nameof(AtmosphereGas2), AtmosphereGas2 },
            { nameof(AtmosphereGasPercentage2), AtmosphereGasPercentage2 },
            { nameof(PrimaryCoreElement), PrimaryCoreElement },
            { nameof(Geology), Geology },
            { nameof(OtherNotes), OtherNotes },
            { nameof(HasSandworms), HasSandworms },
            { nameof(WikiLink), WikiLink },
            { nameof(PortalRepository), PortalRepository },
            { nameof(ExternalLink1), ExternalLink1 },
            { nameof(ExternalLink2), ExternalLink2 },
            { nameof(Garden), Garden },
            { nameof(DocumentSequence), DocumentSequence },
            { nameof(PlanetGlyphs), PlanetGlyphs },
            { nameof(ResearchTeam), ResearchTeam },
            { nameof(PlanetOrMoonAddedInOrigins), PlanetOrMoonAddedInOrigins },
            { nameof(LegacyPCPlanetName), LegacyPCPlanetName },
            { nameof(LegacyPCDiscoveryEra), LegacyPCDiscoveryEra },
            { nameof(LegacyPCDiscoverersGamerTagName), LegacyPCDiscoverersGamerTagName },
            { nameof(LegacyPCDiscoveryDate), LegacyPCDiscoveryDate },
            { nameof(LegacyPSPlanetName), LegacyPSPlanetName },
            { nameof(LegacyPSDiscoveryEra), LegacyPSDiscoveryEra },
            { nameof(LegacyPSDiscoverersGamerTagName), LegacyPSDiscoverersGamerTagName },
            { nameof(LegacyPSDiscoveryDate), LegacyPSDiscoveryDate },
            { nameof(LegacyXboxPlanetName), LegacyXboxPlanetName },
            { nameof(LegacyXboxDiscoveryEra), LegacyXboxDiscoveryEra },
            { nameof(LegacyXboxDiscoverersGamerTagName), LegacyXboxDiscoverersGamerTagName },
            { nameof(LegacyXboxDiscoveryDate), LegacyXboxDiscoveryDate },
            { nameof(HistoricalPlanetNameReset), HistoricalPlanetNameReset },
            { nameof(HistoricalPlanetNamePlatform), HistoricalPlanetNamePlatform },
            { nameof(HistoricalPlanetNameLastKnownEra), HistoricalPlanetNameLastKnownEra },
            { nameof(HistoricalPlanetDiscoverCreditBeforeReset), HistoricalPlanetDiscoverCreditBeforeReset },
            { nameof(LegacyWikiLinkPC), LegacyWikiLinkPC },
            { nameof(LegacyWikiLinkPS), LegacyWikiLinkPS },
            { nameof(LegacyWikiLinkXbox), LegacyWikiLinkXbox },
            { nameof(LegacyWikiLinkOther), LegacyWikiLinkOther },
            { nameof(GameVersionNumberForPage), GameVersionNumberForPage },
            { nameof(DocSeqCheck), DocSeqCheck },
        };
    }
}