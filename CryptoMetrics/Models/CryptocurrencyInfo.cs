namespace DataParser.Models
{
    public class CryptocurrencyInfo : ICurrencyInfo
    {
        public string Token { get; }
        public string Price { get; }
        public string MarketCap { get; }
        public string Volume { get; }

        public CryptocurrencyInfo(string token, string price, string marketCap, string volume)
        {
            Token = token;
            Price = price;
            MarketCap = marketCap;
            Volume = volume;
        }
    }
}
