using StarWars.Dtos.Response.People;
using StarWars.Models;

namespace StarWars.Interfaces.People
{
    public interface IPeopleMappingHelper
    {
        PeopleModel MapToModel(PeopleGetResponseDto request);
    }
}
