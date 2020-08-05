using StarWars;
using StarWars.Dtos.Request.Planet;
using StarWars.Dtos.Response.Planet;
using StarWars.Interfaces.Common;
using StarWars.Interfaces.Planet;
using StarWars.Models.Planet;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWar.Helpers.Planet
{
    public class PlanetRequestHelper : IPlanetRequestHelper
    {
        private readonly IRequestHelper _requestHelper;
        private readonly IPlanetMappingHelper _planetMappingHelper;
        private List<PlanetModel> allPageResults = new List<PlanetModel>();

        public PlanetRequestHelper(IRequestHelper requestHelper,
            IPlanetMappingHelper planetMappingHelper)
        {
            _requestHelper = requestHelper;
            _planetMappingHelper = planetMappingHelper;
        }

        public async Task<PlanetModel> GetAsync(string url, PlanetGetRequestDto request)
        {
            var processedUrl = string.Concat(url, request.Id.ToString(), "/");
            var responseDto = await _requestHelper.CallServiceAsync<PlanetGetResponseDto>(processedUrl);

            return _planetMappingHelper.MapToModel(responseDto);
        }

        public async Task<List<PlanetModel>> SearchAsync(string url, PlanetSearchRequestDto request)
        {
            var processedUrl = string.Empty;
  
            if (!string.IsNullOrEmpty(request.Name))
            {
                processedUrl = string.Concat(url, AppSettings.QueryString + request.Name);
            }
            else
            {
                processedUrl = url;
            }

            var responseDto = await _requestHelper.CallServiceAsync<PlanetSearchResponseDto>(processedUrl);
            var results = _planetMappingHelper.MapToModelList(responseDto);
            allPageResults.AddRange(results);

            if (responseDto.next != null)
            {
                await SearchAsync(responseDto.next, request);
            }

            return allPageResults;
        }
    }
}