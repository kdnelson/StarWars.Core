using StarWars.Dtos.Request.Planet;
using StarWars.ViewModels.Planet;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWars.Interfaces.Planet
{
    public interface IPlanetHelper
    {
        Task<GetPlanetViewModel> GetPlanet(PlanetGetRequestDto request);
        Task<SearchPlanetViewModel> SearchPlanetList(PlanetSearchRequestDto request);
        Task<List<SearchPlanetResidentsViewModel>> SearchPlanetResidentsList(PlanetSearchRequestDto request);
    }
}
