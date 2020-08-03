using System.Threading.Tasks;
using StarWars.Interfaces.Common;
using StarWars.Interfaces.People;
using StarWars.Models;

namespace StarWars.Helpers.People
{
    public class PeopleHelper : IPeopleHelper
    {
        private readonly ICommonUrlHelper _commonUrlHelper;
        private readonly IPeopleRequestHelper _peopleRequestHelper;

        public PeopleHelper(ICommonUrlHelper commonUrlHelper,
            IPeopleRequestHelper peopleRequestHelper)
        {
            _commonUrlHelper = commonUrlHelper;
            _peopleRequestHelper = peopleRequestHelper;
        }

        public async Task<PeopleModel> GetResidentsPerPlanetAsync(string url)
        {
            var response = new PeopleModel();
            var planetGetResponse = await _peopleRequestHelper.GetAsync(url);
            if (planetGetResponse != null)
            {
                response = planetGetResponse;
            }

            return response;
        }
    }
}