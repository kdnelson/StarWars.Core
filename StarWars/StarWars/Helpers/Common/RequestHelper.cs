using System.Threading.Tasks;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using StarWars.Interfaces.Common;

namespace StarWars.Helpers.Common
{
    public class RequestHelper : IRequestHelper
    {
        public async Task<T> CallServiceAsync<T>(string url)
        {
            T response = default(T);

            try
            {
                var httpClient = new HttpClient();
                var uri = new Uri(url);
                var serviceResponse = await httpClient.GetAsync(uri);
                var result = await serviceResponse.Content.ReadAsStringAsync();
                var serviceResponseDto = JsonConvert.DeserializeObject<T>(result);
                response = serviceResponseDto;
            }
            catch (Exception)
            {
            }

            return response;
        }
    }
}