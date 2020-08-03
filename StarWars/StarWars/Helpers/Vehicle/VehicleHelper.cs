using System.Threading.Tasks;
using StarWars.Dtos.Request.Vehicle;
using StarWars.Enums;
using StarWars.Interfaces.Common;
using StarWars.Interfaces.Vehicle;
using StarWars.ViewModels.Vehicle;

namespace StarWars.Helpers.Vehicle
{
    public class VehicleHelper : IVehicleHelper
    {
        private readonly ICommonUrlHelper _commonUrlHelper;
        private readonly IVehicleRequestHelper _vehicleRequestHelper;
        private readonly IVehicleDecoratorHelper _vehicleDecoratorHelper;

        public VehicleHelper(ICommonUrlHelper commonUrlHelper,
            IVehicleRequestHelper vehicleRequestHelper,
            IVehicleDecoratorHelper vehicleDecoratorHelper)
        {
            _commonUrlHelper = commonUrlHelper;
            _vehicleRequestHelper = vehicleRequestHelper;
            _vehicleDecoratorHelper = vehicleDecoratorHelper;
        }

        public async Task<SearchVehicleViewModel> SearchVehicleList(VehicleSearchRequestDto request)
        {
            var response = new SearchVehicleViewModel();    
            var vehicleSearchRequestUrl = _commonUrlHelper.GetApiUrl(ApiRequestType.VehicleSearchUrl);
            var vehicleResponse = await _vehicleRequestHelper.SearchAsync(vehicleSearchRequestUrl, request);
            if (vehicleResponse != null)
            {
                response = _vehicleDecoratorHelper.SearchViewModel(vehicleResponse);
            }

            return response;
        }
    }
}
