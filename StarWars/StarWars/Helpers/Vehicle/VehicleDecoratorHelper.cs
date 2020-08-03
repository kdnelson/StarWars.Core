using System.Collections.Generic;
using System.Linq;
using StarWars.Interfaces.Vehicle;
using StarWars.Models;
using StarWars.Models.Vehicle;
using StarWars.ViewModels.Vehicle;

namespace StarWars.Helpers.Planet
{
    public class VehicleDecoratorHelper : IVehicleDecoratorHelper
    {
        public SearchVehicleViewModel SearchViewModel(List<VehicleModel> modelList)
        {
            var response = new SearchVehicleViewModel();
            var vehicleWithValidCostInCreditsTotal = 0;
            var validCostInCreditsVehicleModelList = new List<VehicleModel>();
            var nonValidCostInCreditsVehicleModelList = new List<VehicleModel>();

            if (modelList != null)
            {
                if (modelList.Any())
                {
                    foreach (var item in modelList)
                    {
                        if (item.CostInCredits != -1)
                        {
                            vehicleWithValidCostInCreditsTotal++;
                            validCostInCreditsVehicleModelList.Add(item);
                        }
                        else
                        {
                            nonValidCostInCreditsVehicleModelList.Add(item);
                        }
                    }

                    response.VehicleWithValidCostInCreditsTotal = vehicleWithValidCostInCreditsTotal.ToString();
                    var uniqueManufacturers = ProcessManufacturerGroups(validCostInCreditsVehicleModelList);
                    response.UniqueManufacturerTotal = uniqueManufacturers.Count.ToString();
                    response.UniqueManufacturerList = uniqueManufacturers
                        .OrderByDescending(o => o.GroupListCount)
                        .ThenByDescending(o => o.CostInCreditsPerGroupAverage).ToList();
                    response.VehicleModelList = validCostInCreditsVehicleModelList.OrderByDescending(o => o.CostInCredits).ToList();
                    response.VehicleModelList.AddRange(nonValidCostInCreditsVehicleModelList);
                }
            }

            return response;
        }

        private List<ManufacturerModel> ProcessManufacturerGroups(List<VehicleModel> validCostInCreditsVehicleModelList)
        {
            var response = new List<ManufacturerModel>();
            var manufacturerModelList = validCostInCreditsVehicleModelList.GroupBy(
                o => o.Manufacturer,
                (key, group) => new ManufacturerModel()
                {
                    Name = key,
                    GroupListCount = group.ToList().Count.ToString(),
                    CostInCreditsPerGroupAverage = 0,
                    GroupList = group.ToList()
                }).ToList();

            foreach (var item in manufacturerModelList)
            {
                int groupListCost = 0;

                foreach (var group in item.GroupList)
                {
                    groupListCost = groupListCost + group.CostInCredits;
                }

                if (groupListCost > 0)
                {
                    item.CostInCreditsPerGroupAverage = (groupListCost / item.GroupList.Count);
                }
                else
                {
                    item.CostInCreditsPerGroupAverage = 0;
                }
            }

            response = manufacturerModelList;

            return response;
        }
    }
}