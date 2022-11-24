using DemoUnitTest.ServiceModel;
using System.Threading.Tasks;

namespace DemoUnitTest.ApiServices
{
    public interface IGenderService
    {
        Task<GenderPrediction> GetGenderPrediction(string name);
    }
}
