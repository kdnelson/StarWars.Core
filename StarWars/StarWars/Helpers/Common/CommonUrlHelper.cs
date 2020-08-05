using StarWars.Enums;
using StarWars.Interfaces.Common;

namespace StarWars.Helpers.Common
{
    public class CommonUrlHelper : ICommonUrlHelper
    {
        public string GetApiUrl(ApiRequestType urlRequest)
        {
            var response = string.Empty;

            switch (urlRequest)
            {
                case ApiRequestType.PlanetGetUrl:
                    response = "planets/";
                    break;
                case ApiRequestType.PlanetSearchUrl:
                    response = "planets/";
                    break;
                case ApiRequestType.VehicleSearchUrl:
                    response = "vehicles/";
                    break;
            }

            return $"{AppSettings.BaseUrl}/{response}";
        }
    }
}
