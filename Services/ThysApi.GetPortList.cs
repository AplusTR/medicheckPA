using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using ThyUcusArama.Models.GetPortList;

namespace ThyUcusArama.Services
{
    public partial class ThysApi
    {
        public async Task<GetPortListResponse> GetPortListAsync(GetPortListRequest request)
        {
            var jsonRequest = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{_baseUrl}/getPortList", content);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<GetPortListResponse>(jsonResponse);
        }
    }
}