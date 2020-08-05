using System.Threading.Tasks;

namespace StarWars.Interfaces.Common
{
    public interface IRequestHelper
    {      
        Task<T> CallServiceAsync<T>(string url);
    }
}