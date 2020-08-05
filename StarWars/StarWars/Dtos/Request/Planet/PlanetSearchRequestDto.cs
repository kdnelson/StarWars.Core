using StarWars.Interfaces.Common;

namespace StarWars.Dtos.Request.Planet
{
    public class PlanetSearchRequestDto : IRequest
    {
        public string Name { get; set; }
    }
}
