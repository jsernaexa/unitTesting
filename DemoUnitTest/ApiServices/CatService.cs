using DemoUnitTest.ServiceModel;
using DemoUnitTest.Services;
using System.Threading.Tasks;

namespace DemoUnitTest.ApiServices
{
    public class CatService : ICatService
    {
        private readonly ICatsApiService _catsApiService;

        public CatService(ICatsApiService catsApiService)
        {
            _catsApiService = catsApiService;
        }
        public async Task<CatFact> GetCatFact(int maxLenght)
        {
            var catResponse = await _catsApiService.GetCatFact();
            if (maxLenght >= 1)
            {
                catResponse = catResponse.Length <= maxLenght ? catResponse : null;
            }
            return catResponse;
        }
    }
}
