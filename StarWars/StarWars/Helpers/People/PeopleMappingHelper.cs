using StarWars.Dtos.Response.People;
using StarWars.Interfaces.People;
using StarWars.Models;

namespace StarWars.Helpers.People
{
    public class PeopleMappingHelper : IPeopleMappingHelper
    {
        public PeopleModel MapToModel(PeopleGetResponseDto request)
        {
            var response = new PeopleModel
            {
                Name = request.name,
                Height = request.height,
                Weight = request.mass,
                HairColor = request.hair_color,
                SkinColor = request.skin_color,
                EyeColor = request.eye_color,
                Gender = request.gender
            };

            return response;
        }
    }
}