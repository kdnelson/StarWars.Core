using StarWars.Dtos.Response.Vehicle;
using StarWars.Models.Vehicle;
using System.Collections.Generic;

namespace StarWars.Interfaces.Vehicle
{
    public interface IVehicleMappingHelper
    {
        List<VehicleModel> MapToModelList(VehicleSearchResponseDto request);
    }
}
