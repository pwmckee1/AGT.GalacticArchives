using AGT.GalacticArchives.Core.Models.Application;
using AGT.GalacticArchives.Core.Models.InGame.Locations;
using AGT.GalacticArchives.Core.Models.Requests;
using AGT.GalacticArchives.Core.Models.Responses;
using AGT.GalacticArchives.Globalization;
using AGT.GalacticArchives.Services.Services.InGameEnvironments;

namespace AGT.GalacticArchives.Services.Decorators;

public class ValidatedRegionServiceDecorator(IRegionService regionService)
    : IRegionService
{
    public async Task<RegionResponse?> GetRegionByIdAsync(Guid regionId)
    {
        return await regionService.GetRegionByIdAsync(regionId);
    }

    public async Task<PagedResponse<RegionResponse>> GetRegionsAsync(RegionSearchRequest request)
    {
        return await regionService.GetRegionsAsync(request);
    }

    public async Task<RegionResponse> UpsertRegionAsync(RegionRequest request)
    {
        if (!request.Galaxy.HasValue)
        {
            throw new ArgumentNullException(string.Format(RegionResource.MustHaveGalaxy, request.Name));
        }

        if (string.IsNullOrEmpty(request.Name))
        {
            throw new ArgumentNullException(
                string.Format(GeneralErrorResource.PropertyMissing, $"{nameof(Region)} => {nameof(Region.Name)}"));
        }

        if (string.IsNullOrEmpty(request.GalacticCoordinates))
        {
            throw new ArgumentNullException(
                string.Format(
                    GeneralErrorResource.PropertyMissing,
                    $"{nameof(Region)} => {nameof(Region.GalacticCoordinates)}"));
        }

        if (request.SurveyDate == null)
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