using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoMetrics.Models
{
    public class RequestSender : IRequestSender
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<HttpResponseMessage> SendGetAsync(Uri uri)
        {
            var result = await _httpClient.GetAsync(uri);
            return result;
        }

        public async Task<HttpResponseMessage> SendPostAsync(RequestData requestData)
        {
            var content = new FormUrlEncodedContent(requestData.Parameters);

            HttpResponseMessage response = await _httpClient.PostAsync(requestData.Url, content);

            return response;
        }
    }
}
