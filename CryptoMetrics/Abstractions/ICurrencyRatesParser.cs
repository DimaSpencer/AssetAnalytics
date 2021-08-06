using System;
using System.Threading.Tasks;

namespace DataParser
{
    public interface ICurrencyRatesParser<TResult, TConfig>
        where TResult : class, new()
        where TConfig : IParserConfiguration, new()
    {
        TConfig Configuration { get; }
        Task<TResult> ParseCurrencyAsync();
        void ChangeConfiguration(Action<TConfig> configuration);
    }
}
