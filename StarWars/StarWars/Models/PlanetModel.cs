using System.Collections.Generic;

namespace StarWars.Models.Planet
{
    public class PlanetModel
    {
        public string Name { get; set; }
        public string RotationalPeriod { get; set; }
        public string OrbitalPeriod { get; set; }
        public int Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string SurfaceWater { get; set; }
        public string Population { get; set; }
        public List<string> Residents { get; set; }
        public List<string> Films { get; set; }
        public string Url { get; set; }

        public PlanetModel()
        {
            Residents = new List<string>();
            Films = new List<string>();
        }
    }
}
