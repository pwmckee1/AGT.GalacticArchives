using AGT.GalacticArchives.Core.Managers.Environments;
using AGT.GalacticArchives.Core.Models.Entities;
using AGT.GalacticArchives.Core.Models.Requests.Environments;
using AGT.GalacticArchives.Core.Models.Responses.Environments;
using AGT.GalacticArchives.Globalization;
using AGT.GalacticArchives.Services.Services.Environments;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedRegionServiceDecorator(IRegionService regionService, IGalaxyManager galaxyManager)
    : IRegionService
{
    public async Task<RegionResponse?> GetRegionByIdAsync(Guid regionId)
    {
        return await regionService.GetRegionByIdAsync(regionId);
    }

    public async Task<HashSet<RegionResponse>> GetRegionsAsync(RegionRequest request)
    {
        return await regionService.GetRegionsAsync(request);
    }

    public async Task<RegionResponse> UpsertRegionAsync(RegionRequest request)
    {
        if (!request.GalaxyId.HasValue)
        {
            throw new ArgumentNullException(string.Format(RegionResource.MustHaveGalaxy, request.Name));
        }

        var galaxy = await galaxyManager.GetGalaxyByIdAsync(request.GalaxyId.Value);
        if (galaxy == null)
        {
            throw new ArgumentException(
                string.Format(
                    GeneralErrorResource.InvalidGameDataId,
                    request.GalaxyId.Value,
                    $"{nameof(Region)} => {nameof(Region.GalaxyId)}"));
        }

        if (string.IsNullOrEmpty(request.Name))
        {
            throw new ArgumentNullException(
                string.Format(GeneralErrorResource.PropertyMissing, $"{nameof(Region)} => {nameof(Region.Name)}"));
        }

        if (string.IsNullOrEmpty(request.Coordinates))
        {
            throw new ArgumentNullException(
                string.Format(
                    GeneralErrorResource.PropertyMissing,
                    $"{nameof(Region)} => {nameof(Region.Coordinates)}"));
        }

        if (string.IsNullOrEmpty(request.SurveyDate))
        {
            throw new ArgumentNullException(
                string.Format(
                    GeneralErrorResource.PropertyMissing,
                    $"{nameof(Region)} => {nameof(Region.SurveyDate)}"));
        }

        if (string.IsNullOrEmpty(request.EarliestKnownSurveyor))
        {
            throw new ArgumentNullException(
                string.Format(
                    GeneralErrorResource.PropertyMissing,
                    $"{nameof(Region)} => {nameof(Region.EarliestKnownSurveyor)}"));
        }

        if (string.IsNullOrEmpty(request.GameRelease))
        {
            throw new ArgumentNullException(
                string.Format(
                    GeneralErrorResource.PropertyMissing,
                    $"{nameof(Region)} => {nameof(Region.GameRelease)}"));
        }

        return await regionService.UpsertRegionAsync(request);
    }

    public async Task DeleteRegionAsync(Guid regionId)
    {
        await regionService.DeleteRegionAsync(regionId);
    }
}