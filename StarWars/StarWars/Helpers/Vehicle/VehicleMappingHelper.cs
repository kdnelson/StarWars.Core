using System.Collections.Generic;
using System.Linq;
using StarWars.Dtos.Response.Vehicle;
using StarWars.Interfaces.Vehicle;
using StarWars.Models.Vehicle;

namespace StarWars.Helpers.Vehicle
{
    public class VehicleMappingHelper : IVehicleMappingHelper
    {
        public List<VehicleModel> MapToModelList(VehicleSearchResponseDto request)
        {
            var response = new List<VehicleModel>();

            if (request.results.Any())
            {
                foreach (var item in request.results)
                {
                    response.Add(new VehicleModel
                    {
                        Name = item.name,
                        Model = item.model,
                        Manufacturer = item.manufacturer,
                        CostInCredits = TryParseCostInCredits(item.cost_in_credits),
                        Length = item.length,
                        MaxAtmospheringSpeed = item.max_atmosphering_speed,
                        Crew = item.crew,
                        Passengers = item.passengers,
                        CargoCapacity = item.cargo_capacity,
                        Consumables = item.consumables,
                        VehicleClass = item.vehicle_class,
                        Pilots = item.pilots,
                        Films = item.films,
                        Url = item.url,
                    });
                }
            }

            return response;
        }

        private int TryParseCostInCredits(string costInCreditsStr)
        {
            bool isValidCostInCredits = System.Int32.TryParse(costInCreditsStr, out int validCostInCreditsStr);
            if (isValidCostInCredits)
            {
                return validCostInCreditsStr;
            }
            else
            {
                return -1;
            }
        }
    }
}