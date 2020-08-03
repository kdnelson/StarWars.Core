using StarWars.Enums;

namespace StarWars.Interfaces.Common
{
    public interface ICommonUrlHelper
    {
        string GetApiUrl(ApiRequestType urlRequest);
    }
}
