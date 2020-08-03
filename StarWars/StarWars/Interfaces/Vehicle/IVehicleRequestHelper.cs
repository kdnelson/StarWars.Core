using StarWars.Dtos.Request.Vehicle;
using StarWars.Models.Vehicle;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWars.Interfaces.Vehicle
{
    public interface IVehicleRequestHelper
    {
        Task<List<VehicleModel>> SearchAsync(string url, VehicleSearchRequestDto request);
    }
}