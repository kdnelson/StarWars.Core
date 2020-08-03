using StarWars.Interfaces.Common;

namespace StarWars.Dtos.Request.Vehicle
{
    public class VehicleSearchRequestDto : IRequest
    {
        public string Name { get; set; }
    }
}