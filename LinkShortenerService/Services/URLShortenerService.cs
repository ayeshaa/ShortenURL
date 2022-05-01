using LinkShortenerService.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;

namespace LinkShortenerService.Services
{
    public class URLShortenerService : IURLShortenerService
    {
        private readonly IConfiguration configuration;
        public URLShortenerService()
        {

        }
        public URLShortenerService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public URLResponse UrlShorten(string url)
        {
            var endPoint = this.configuration["TinyURLEndPoint"];
            var token = this.configuration["TinyURLAuthToken"];

            var client = new RestClient(endPoint + "create?api_token=" + token);
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("expires_at", "");
            request.AddParameter("url", url);
            var response = client.Execute(request);
            URLResponse responseToken = JsonConvert.DeserializeObject<URLResponse>(response.Content);

            return responseToken;
        }
        public URLResponse UrlStatistics(string domain)
        {
            var endPoint = this.configuration["TinyURLEndPoint"];
            var token = this.configuration["TinyURLAuthToken"];

            var client = new RestClient(endPoint + "?analytics/status?api_token=" + token);
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("expires_at", "");
            request.AddParameter("domain", domain);
            var response = client.Execute(request);
            URLResponse responseToken = JsonConvert.DeserializeObject<URLResponse>(response.Content);

            return responseToken;
        }
    }
}
