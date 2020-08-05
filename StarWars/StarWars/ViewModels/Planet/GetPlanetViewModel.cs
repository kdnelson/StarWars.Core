using StarWars.Models.Planet;

namespace StarWars.ViewModels.Planet
{
    public class GetPlanetViewModel
    {
        public PlanetModel PlanetModel { get; set; }

        public GetPlanetViewModel()
        {
            PlanetModel = new PlanetModel();
        }
    }
}
