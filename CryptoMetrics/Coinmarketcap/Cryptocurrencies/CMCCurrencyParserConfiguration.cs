using DataParser;
using System;

namespace DataParser
{
    public class CMCCurrencyParserConfiguration : IParserConfiguration
    {
        public Uri BaseUri { get; } = new Uri("https://coinmarketcap.com");
    }
}
