using StarWars.Models.Planet;
using System.Collections.Generic;

namespace StarWars.ViewModels.Planet
{
    public class SearchPlanetViewModel
    {
        public int DiameterAverage { get; set; }
        public List<PlanetModel> PlanetModelList { get; set; }

        public SearchPlanetViewModel()
        {
            PlanetModelList = new List<PlanetModel>();
        }
    }
}
