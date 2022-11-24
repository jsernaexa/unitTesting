using DemoUnitTest.ServiceModel;
using DemoUnitTest.Services;
using System.Threading.Tasks;

namespace DemoUnitTest.ApiServices
{
    public class GenderService : IGenderService
    {
        private readonly IGenderApiService _genderApiService;

        public GenderService(IGenderApiService genderApiService)
        {
            _genderApiService = genderApiService;
        }
        public async Task<GenderPrediction> GetGenderPrediction(string name)
        {
            return await _genderApiService.GetGenderPrediction(name);
        }
    }
}
