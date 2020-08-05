using StarWars.Models;
using System.Threading.Tasks;

namespace StarWars.Interfaces.People
{
    public interface IPeopleRequestHelper
    {
        Task<PeopleModel> GetAsync(string url);
    }
}