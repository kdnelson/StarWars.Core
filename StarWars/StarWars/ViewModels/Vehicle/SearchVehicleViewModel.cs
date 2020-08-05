using StarWars.Models;
using StarWars.Models.Vehicle;
using System.Collections.Generic;

namespace StarWars.ViewModels.Vehicle
{
    public class SearchVehicleViewModel
    {
        public string VehicleWithValidCostInCreditsTotal { get; set; }
        public string UniqueManufacturerTotal { get; set; }
        public List<ManufacturerModel> UniqueManufacturerList { get; set; }
        public List<VehicleModel> VehicleModelList { get; set; }

        public SearchVehicleViewModel()
        {
            UniqueManufacturerList = new List<ManufacturerModel>();
            VehicleModelList = new List<VehicleModel>();
        }
    }
}
