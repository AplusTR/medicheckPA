using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace ThyUcusArama.Services
{
    public partial class ThysApi
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _baseUrl = "https://api.turkishairlines.com/business/anonymous/v9";

        public ThysApi(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("apisecret", _apiKey);
            _httpClient.DefaultRequestHeaders.Add("clientusername", "YOUR_CLIENT_USER_NAME");
            _httpClient.DefaultRequestHeaders.Add("clientpassword", "YOUR_CLIENT_PASSWORD");
            _httpClient.DefaultRequestHeaders.Add("clienttransactionid", "YOUR_CLIENT_TRANSACTION_ID");
            _httpClient.DefaultRequestHeaders.Add("Channel", "REST");

        }
    }
}