using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using CryptoMetrics.Models;
using System.Net.Http;
using System;

namespace CryptoMetrics.Models
{
    public interface IRequestSender
    {
        Task<HttpResponseMessage> SendGetAsync(Uri uri);
        Task<HttpResponseMessage> SendPostAsync(RequestData requestData);
    }
}
