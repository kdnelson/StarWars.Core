using StarWars.Models.Vehicle;
using StarWars.ViewModels.Vehicle;
using System.Collections.Generic;

namespace StarWars.Interfaces.Vehicle
{
    public interface IVehicleDecoratorHelper
    {
        SearchVehicleViewModel SearchViewModel(List<VehicleModel> modelList);
    }
}
