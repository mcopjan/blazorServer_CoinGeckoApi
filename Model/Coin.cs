using System;
namespace CoinGeckoApi_Blazor.Model
{
    public class Coin
    {
        public string id { get; set; }
        public MarketData market_data { get; set; }
        public CommunityData community_data { get; set; }
        public DateTime last_updated { get; set; }
    }


    public class CurrentPrice
    {
        public double gbp { get; set; }
    }

    public class MarketCap
    {
        public double gbp { get; set; }
    }



    public class PriceChange24hInCurrency
    {
        public double gbp { get; set; }
    }


    public class PriceChangePercentage24hInCurrency
    {
        public double gbp { get; set; }
    }

    public class MarketData
    {
        public CurrentPrice current_price { get; set; }
        public MarketCap market_cap { get; set; }
        public PriceChange24hInCurrency price_change_24h_in_currency { get; set; }
        public PriceChangePercentage24hInCurrency price_change_percentage_24h_in_currency { get; set; }
        public DateTime last_updated { get; set; }
    }

    public class CommunityData
    {
        public int twitter_followers { get; set; }
    }
}
