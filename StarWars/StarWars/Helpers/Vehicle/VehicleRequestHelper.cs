using StarWars;
using StarWars.Dtos.Request.Vehicle;
using StarWars.Dtos.Response.Vehicle;
using StarWars.Interfaces.Common;
using StarWars.Interfaces.Vehicle;
using StarWars.Models.Vehicle;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWare.Helpers.Vehicle
{
    public class VehicleRequestHelper : IVehicleRequestHelper
    {
        private readonly IRequestHelper _requestHelper;
        private readonly IVehicleMappingHelper _vehicleMappingHelper;
        private List<VehicleModel> allPageResults = new List<VehicleModel>();

        public VehicleRequestHelper(IRequestHelper requestHelper,
            IVehicleMappingHelper vehicleMappingHelper)
        {
            _requestHelper = requestHelper;
            _vehicleMappingHelper = vehicleMappingHelper;
        }

        public async Task<List<VehicleModel>> SearchAsync(string url, VehicleSearchRequestDto request)
        {
            var processedUrl = string.Empty;

            if (!String.IsNullOrEmpty(request.Name))
            {
                processedUrl = string.Concat(url, AppSettings.QueryString + request.Name);
            }
            else
            {
                processedUrl = url;
            }

            var responseDto = await _requestHelper.CallServiceAsync<VehicleSearchResponseDto>(processedUrl);
            var results = _vehicleMappingHelper.MapToModelList(responseDto);
            allPageResults.AddRange(results);

            if (responseDto.next != null)
            {
                await SearchAsync(responseDto.next, request);
            }

            return allPageResults;
        }
    }
}