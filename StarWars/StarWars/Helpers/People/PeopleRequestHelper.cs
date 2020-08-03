using StarWars.Dtos.Response.People;
using StarWars.Interfaces.Common;
using StarWars.Interfaces.People;
using StarWars.Models;
using System.Threading.Tasks;

namespace StarWars.Helpers.People
{
    public class PeopleRequestHelper : IPeopleRequestHelper
    {
        private readonly IRequestHelper _requestHelper;
        private readonly IPeopleMappingHelper _peopleMappingHelper;

        public PeopleRequestHelper(IRequestHelper requestHelper,
            IPeopleMappingHelper peopleMappingHelper)
        {
            _requestHelper = requestHelper;
            _peopleMappingHelper = peopleMappingHelper;
        }

        public async Task<PeopleModel> GetAsync(string url)
        {
            var responseDto = await _requestHelper.CallServiceAsync<PeopleGetResponseDto>(url);

            return _peopleMappingHelper.MapToModel(responseDto);
        }
    }
}