using StarWars.Models.Planet;
using StarWars.ViewModels.Planet;
using System.Collections.Generic;

namespace StarWars.Interfaces.Planet
{
    public interface IPlanetDecoratorHelper
    {
        GetPlanetViewModel GetViewModel(PlanetModel model);
        SearchPlanetViewModel SearchViewModel(List<PlanetModel> modelList);
    }
}
