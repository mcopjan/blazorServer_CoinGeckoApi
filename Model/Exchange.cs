using Newtonsoft.Json;

namespace CoinGeckoApi_Blazor.Model
{
    public class Exchange
    {
        public string id { get; set; }
        public string name { get; set; }
        public int? year_established { get; set; }
        public string country { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string image { get; set; }
        public bool? has_trading_incentive { get; set; }
        public int? trust_score { get; set; }
        public int trust_score_rank { get; set; }
        public double trade_volume_24h_btc { get; set; }
        public double trade_volume_24h_btc_normalized { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
