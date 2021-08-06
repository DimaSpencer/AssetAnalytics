using System;
using System.Collections.Generic;

namespace CryptoMetrics.Models
{
    public class RequestData
    {
        public string Url { get; set; }
        public IReadOnlyDictionary<string, string> Parameters { get => _parameters; }
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();

        public void AddParameter(string key, string value)
        {
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(value))
                throw new ArgumentException("key or value is empty");

            _parameters.Add(key, value);
        }
    }
}
