using System.Collections.Generic;

namespace StarWars.Dtos.Response.Planet
{
    public class PlanetSearchResponseDto
    {
        public string count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<PlanetResults> results { get; set; }

        PlanetSearchResponseDto()
        {
            results = new List<PlanetResults>();
        }
    }

    public class PlanetResults
    {
        public string name { get; set; }
        public string rotation_period { get; set; }
        public string orbital_period { get; set; }
        public string diameter { get; set; }
        public string climate { get; set; }
        public string gravity { get; set; }
        public string terrain { get; set; }
        public string surface_water { get; set; }
        public string population { get; set; }
        public List<string> residents { get; set; }
        public List<string> films { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
        public string url { get; set; }

        public PlanetResults()
        {
            residents = new List<string>();
            films = new List<string>();
        }
    }
}
