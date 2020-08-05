using System.Collections.Generic;
using System.Linq;
using StarWars.Interfaces.Planet;
using StarWars.Models.Planet;
using StarWars.ViewModels.Planet;

namespace StarWars.Helpers.Planet
{
    public class PlanetDecoratorHelper : IPlanetDecoratorHelper
    {
        public GetPlanetViewModel GetViewModel(PlanetModel model)
        {
            var response = new GetPlanetViewModel();

            if (model != null)
            {
                response.PlanetModel = model;
            }

            return response;
        }

        public SearchPlanetViewModel SearchViewModel(List<PlanetModel> modelList)
        {
            var response = new SearchPlanetViewModel();
            var planetDiameterTotal = 0;
            var validDiameterPlanetModelList = new List<PlanetModel>();
            var nonValidDiameterPlanetModelList = new List<PlanetModel>();

            if (modelList != null)
            {
                if (modelList.Any())
                {
                    foreach (var item in modelList)
                    {
                        if (item.Diameter != -1)
                        {
                            planetDiameterTotal = planetDiameterTotal + item.Diameter;
                            validDiameterPlanetModelList.Add(item);
                        }
                        else
                        {
                            nonValidDiameterPlanetModelList.Add(item);
                        }
                    }

                    response.DiameterAverage = (planetDiameterTotal / modelList.Count);
                    response.PlanetModelList = validDiameterPlanetModelList.OrderByDescending(o => o.Diameter).ToList();
                    response.PlanetModelList.AddRange(nonValidDiameterPlanetModelList);
                }
            }

            return response;
        }
    }
}
