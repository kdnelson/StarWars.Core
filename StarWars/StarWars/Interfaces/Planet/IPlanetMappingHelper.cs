using StarWars.Dtos.Response.Planet;
using StarWars.Models.Planet;
using System.Collections.Generic;

namespace StarWars.Interfaces.Planet
{
    public interface IPlanetMappingHelper
    {
        PlanetModel MapToModel(PlanetGetResponseDto request);
        List<PlanetModel> MapToModelList(PlanetSearchResponseDto request);
    }
}
