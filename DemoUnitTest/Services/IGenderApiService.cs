using DemoUnitTest.ServiceModel;
using System.Threading.Tasks;

namespace DemoUnitTest.Services
{
    public interface IGenderApiService
    {
        Task<GenderPrediction> GetGenderPrediction(string name);
    }
}
