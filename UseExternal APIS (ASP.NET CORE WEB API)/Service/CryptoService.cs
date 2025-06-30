using System.Net.Http.Json;
using UseExternal_APIS__ASP.NET_CORE_WEB_API_.Model;

namespace UseExternal_APIS__ASP.NET_CORE_WEB_API_
{
    public class CryptoService
    {
        private readonly HttpClient _httpClient;

        public CryptoService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            if (!_httpClient.DefaultRequestHeaders.Contains("User-Agent"))
            {
                _httpClient.DefaultRequestHeaders.Add("User-Agent", "ASP.NET Core Web API Client");
            }
        }
        

        public async Task<List<CryptoCoin>> GetLiveCoinsAsync()
        {
            var url = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd";

            var response = await _httpClient.GetFromJsonAsync<List<CryptoCoin>>(url);
            return response;

        }


    }
}
