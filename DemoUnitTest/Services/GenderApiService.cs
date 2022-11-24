using DemoUnitTest.ServiceModel;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoUnitTest.Services
{
    public class GenderApiService : IGenderApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;
        public GenderApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<GenderPrediction> GetGenderPrediction(string name)
        {
            var uri = $"{_remoteServiceBaseUrl}/?name={name}";
            var responseString = await _httpClient.GetStringAsync(uri);
            var genderPrediction = JsonConvert.DeserializeObject<GenderPrediction>(responseString);
            return genderPrediction;
        }
    }
}
