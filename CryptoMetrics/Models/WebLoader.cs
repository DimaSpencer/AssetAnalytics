using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using CryptoMetrics.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DataParser
{
    public static class WebLoader
    {
        private static RequestSender _requestSender = new RequestSender();
        public static async Task<IHtmlDocument> LoadHTMLDocumentAsync(Uri uri)
        {
            if (uri is null)
                throw new ArgumentNullException(nameof(uri));

            var response = await _requestSender.SendGetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string htmlString = await response.Content.ReadAsStringAsync();
                return new HtmlParser().ParseDocument(htmlString);
            }
            else
            {
                throw new HttpRequestException(response.StatusCode.ToString()); 
            }
        }
    }
}
