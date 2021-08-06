using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataParser
{
    public interface IDataParser
    {
        IParserConfiguration Configuration { get; set; }
        IParserConfiguration CourceParseAsync();
        void SetConfiguration(Action<IParserConfiguration> configuration);
    }
}
