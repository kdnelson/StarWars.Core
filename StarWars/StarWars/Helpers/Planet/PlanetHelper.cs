using StarWars.Dtos.Request.Planet;
using StarWars.Enums;
using StarWars.Interfaces.Common;
using StarWars.Interfaces.People;
using StarWars.Interfaces.Planet;
using StarWars.Models;
using StarWars.ViewModels.Planet;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWars.Helpers.Planet
{
    public class PlanetHelper : IPlanetHelper
    {
        private readonly ICommonUrlHelper _commonUrlHelper;
        private readonly IPlanetRequestHelper _planetRequestHelper;
        private readonly IPlanetDecoratorHelper _planetModelDecoratorHelper;
        private readonly IPeopleHelper _peopleHelper;

        public PlanetHelper(ICommonUrlHelper commonUrlHelper,
            IPlanetRequestHelper planetRequestHelper,
            IPlanetDecoratorHelper planetDecoratorHelper,
            IPeopleHelper peopleHelper)
        {
            _commonUrlHelper = commonUrlHelper;
            _planetRequestHelper = planetRequestHelper;
            _planetModelDecoratorHelper = planetDecoratorHelper;
            _peopleHelper = peopleHelper;
        }

        public async Task<GetPlanetViewModel> GetPlanet(PlanetGetRequestDto request)
        {
            var response = new GetPlanetViewModel();
            var planetGetRequestUrl = _commonUrlHelper.GetApiUrl(ApiRequestType.PlanetGetUrl);
            var planetGetResponse = await _planetRequestHelper.GetAsync(planetGetRequestUrl, request);
            if (planetGetResponse != null)
            {
                response = _planetModelDecoratorHelper.GetViewModel(planetGetResponse);
            }

            return response;
        }

        public async Task<SearchPlanetViewModel> SearchPlanetList(PlanetSearchRequestDto request)
        {
            var response = new SearchPlanetViewModel();
            var planetSearchRequestUrl = _commonUrlHelper.GetApiUrl(ApiRequestType.PlanetSearchUrl);
            var planetListResponse = await _planetRequestHelper.SearchAsync(planetSearchRequestUrl, request);
            if (planetListResponse.Any())
            {
                response = _planetModelDecoratorHelper.SearchViewModel(planetListResponse);
            }

            return response;
        }

        public async Task<List<SearchPlanetResidentsViewModel>> SearchPlanetResidentsList(PlanetSearchRequestDto request)
        {
            var response = new List<SearchPlanetResidentsViewModel>();
            var planetSearchRequestUrl = _commonUrlHelper.GetApiUrl(ApiRequestType.PlanetSearchUrl);
            var planetListResponse = await _planetRequestHelper.SearchAsync(planetSearchRequestUrl, request);
            if (planetListResponse.Any())
            {
                foreach (var item in planetListResponse)
                {
                    var residentList = new List<PeopleModel>();

                    if (item.Residents.Any())
                    {
                        foreach (var residentUrl in item.Residents)
                        {
                            var peopleGetResponse = await _peopleHelper.GetResidentsPerPlanetAsync(residentUrl);
                            if (peopleGetResponse != null)
                            {
                                residentList.Add(peopleGetResponse);
                            }
                        }

                        response.Add(new SearchPlanetResidentsViewModel()
                        {
                            Name = item.Name,
                            ResidentlList = residentList.OrderBy(o => o.Name).ToList()
                        });

                        residentList = null;
                    }
                }
            }

            return response;
        }
    }
}