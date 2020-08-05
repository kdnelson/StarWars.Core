using StarWars.Interfaces.Common;

namespace StarWars.Dtos.Request.Planet
{
    public class PlanetGetRequestDto : IRequest
    {
        public int Id { get; set; }
    }
}
