using AngleSharp.Html.Dom;
using DataParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataParser
{

    public partial class CoinMarketCapPriceParser : ICurrencyRatesParser<List<CryptocurrencyInfo>, CMCCurrencyParserConfiguration>
    {
        public CMCCurrencyParserConfiguration Configuration { get; private set; }

        public CoinMarketCapPriceParser()
        {
            Configuration = new CMCCurrencyParserConfiguration();
        }
        public CoinMarketCapPriceParser(Action<CMCCurrencyParserConfiguration> configuration)
        {
            ChangeConfiguration(configuration);
        }

        public void ChangeConfiguration(Action<CMCCurrencyParserConfiguration> configuration)
        {
            configuration.Invoke(Configuration ??= new CMCCurrencyParserConfiguration());
        }

        //TODO: тут сделать както поприличнее
        public async Task<List<CryptocurrencyInfo>> ParseCurrencyAsync()
        {
            IHtmlDocument htmlDocument = await WebLoader.LoadHTMLDocumentAsync(Configuration.BaseUri);

            List<CryptocurrencyInfo> cryptocurrencies = new List<CryptocurrencyInfo>();
            var symbols = htmlDocument
                .QuerySelectorAll("p")
                .Where(item => item?.ClassName?.Contains("coin-item-symbol") ?? false)
                .Select(item => item.TextContent).ToList();

            var prices = htmlDocument
                .QuerySelectorAll("div")
                .Where(item => item?.ClassName?.Contains("price___3rj7O") ?? false)
                .Select(item => item.TextContent).ToList();

            var marketCaps = htmlDocument
                .QuerySelectorAll("span")
                .Where(item => item?.ClassName?.Contains("sc-1ow4cwt-1 ieFnWP") ?? false)
                .Select(item => item.TextContent).ToList();

            var volumes = htmlDocument
                .QuerySelectorAll("p")
                .Where(item => item?.ClassName?.Contains("sc-1eb5slv-0 kDEzev font_weight_500") ?? false)
                .Select(item => item.TextContent).ToList();

            for (int i = 0; i < symbols.Count(); i++)
            {
                cryptocurrencies.Add(new CryptocurrencyInfo(
                    symbols[i].WithDollarSymbol(), 
                    prices[i].WithDollarSymbol(),
                    marketCaps[i].WithDollarSymbol(),
                    volumes[i].WithDollarSymbol()));
            }
            return cryptocurrencies;
        }
    }
}
