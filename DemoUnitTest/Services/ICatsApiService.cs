using DemoUnitTest.ServiceModel;
using System.Threading.Tasks;

namespace DemoUnitTest.Services
{
    public interface ICatsApiService
    {
        Task<CatFact> GetCatFact();
    }
}
