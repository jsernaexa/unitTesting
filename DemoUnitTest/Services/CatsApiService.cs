using DemoUnitTest.ServiceModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DemoUnitTest.Services
{
    public class CatsApiService : ICatsApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;

        public CatsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CatFact> GetCatFact()
        {
            var uri = $"{_remoteServiceBaseUrl}/fact";
            var responseString = await _httpClient.GetStringAsync(uri);
            var catFact = JsonConvert.DeserializeObject<CatFact>(responseString);
            return catFact;
        }
    }
}
