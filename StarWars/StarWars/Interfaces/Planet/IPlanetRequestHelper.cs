using StarWars.Dtos.Request.Planet;
using StarWars.Models.Planet;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWars.Interfaces.Planet
{
    public interface IPlanetRequestHelper
    {
        Task<PlanetModel> GetAsync(string url, PlanetGetRequestDto request);
        Task<List<PlanetModel>> SearchAsync(string url, PlanetSearchRequestDto request);
    }
}