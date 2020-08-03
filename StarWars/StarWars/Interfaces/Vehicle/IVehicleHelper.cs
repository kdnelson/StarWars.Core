using StarWars.Dtos.Request.Vehicle;
using StarWars.ViewModels.Vehicle;
using System.Threading.Tasks;

namespace StarWars.Interfaces.Vehicle
{
    public interface IVehicleHelper
    {
        Task<SearchVehicleViewModel> SearchVehicleList(VehicleSearchRequestDto request);
    }
}