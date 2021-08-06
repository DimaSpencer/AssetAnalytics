using System;
using System.Collections.Generic;
using System.Text;

namespace DataParser.Models
{
    public interface ICurrencyInfo
    {
        string Token { get; }
        string Price { get; }
    }
}
