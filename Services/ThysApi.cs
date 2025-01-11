using System.Net.Http.Headers;
using System.Net.Http.Json;
using ThyUcusArama.Models;

namespace ThyUcusArama.Services
{
    public class ThysApi
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public ThysApi(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.thy.com/")
            };
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("apikey", _apiKey);
        }

        public async Task<PortListResponse> GetPortListAsync(GetPortListRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("v1/getPortList", request);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<PortListResponse>();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"API Error: {ex.Message}");
                throw;
            }
        }
    }
}