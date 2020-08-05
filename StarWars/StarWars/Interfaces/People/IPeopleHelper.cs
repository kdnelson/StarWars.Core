using StarWars.Models;
using System.Threading.Tasks;

namespace StarWars.Interfaces.People
{
    public interface IPeopleHelper
    {
        Task<PeopleModel> GetResidentsPerPlanetAsync(string url);
    }
}