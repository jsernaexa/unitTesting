using DemoUnitTest.ServiceModel;
using System.Threading.Tasks;

namespace DemoUnitTest.ApiServices
{
    public interface ICatService
    {
        Task<CatFact> GetCatFact(int maxLenght);
    }
}
