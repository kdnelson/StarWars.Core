using System.Collections.Generic;
using System.Linq;
using StarWars.Dtos.Response.Planet;
using StarWars.Interfaces.Planet;
using StarWars.Models.Planet;

namespace StarWars.Helpers.Planet
{
    public class PlanetMappingHelper : IPlanetMappingHelper
    {
        public PlanetModel MapToModel(PlanetGetResponseDto request)
        {
            var response = new PlanetModel
            {
                Name = request.name,
                RotationalPeriod = request.rotation_period,
                OrbitalPeriod = request.orbital_period,
                Diameter = TryParseDiameter(request.diameter),
                Climate = request.climate,
                Gravity = request.gravity,
                Terrain = request.terrain,
                SurfaceWater = request.surface_water,
                Population = request.population,
                Residents = request.residents,
                Films = request.films,
                Url = request.url
            };

            return response;
        }

        public List<PlanetModel> MapToModelList(PlanetSearchResponseDto request)
        {
            var response = new List<PlanetModel>();

            if (request.results.Any())
            {
                foreach (var item in request.results)
                {
                    response.Add(new PlanetModel
                    {
                        Name = item.name,
                        RotationalPeriod = item.rotation_period,
                        OrbitalPeriod = item.orbital_period,
                        Diameter = TryParseDiameter(item.diameter),
                        Climate = item.climate,
                        Gravity = item.gravity,
                        Terrain = item.terrain,
                        SurfaceWater = item.surface_water,
                        Population = item.population,
                        Residents = item.residents,
                        Films = item.films,
                        Url = item.url,
                    });
                }
            }

            return response;
        }

        private int TryParseDiameter(string diamterStr)
        {
            bool isValidDiameter = System.Int32.TryParse(diamterStr, out int validDiameter);
            if (isValidDiameter)
            {
                return validDiameter;
            }
            else
            {
                return -1;
            }
        }
    }
}