using System;
using System.Net.Http;
using System.Threading.Tasks;
using CoinGeckoApi_Blazor.Model;
using Microsoft.AspNetCore.Components;

namespace CoinGeckoApi_Blazor.Services
{
    public class CoinsService
    {
        private readonly HttpClient _httpClient;

        public CoinsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Coin> GetCoinDetailsAsync(string coinId)
        {
            Coin coin = null;
            try
            {
                var tt = await _httpClient.GetStringAsync($"/coins/{coinId}");
                coin =  await _httpClient.GetJsonAsync<Coin>($"/coins/{coinId}");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

            return coin;
            
        }
    }
}
