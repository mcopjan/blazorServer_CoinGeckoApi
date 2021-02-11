using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGeckoApi_Blazor.Model;
using Microsoft.AspNetCore.Components;

namespace CoinGeckoApi_Blazor.Services
{
    public class ExchangesService
    {
        private readonly HttpClient httpClient;

        public ExchangesService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Exchange>> GetExchangesAsync()
        {
            return await httpClient.GetJsonAsync<Exchange[]>("/exchanges");
        }
    }
}
