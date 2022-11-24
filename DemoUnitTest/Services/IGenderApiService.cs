using DemoUnitTest.ServiceModel;

namespace DemoUnitTest.Services
{
    public interface IGenderApiService
    {
        GenderPrediction GetGender();
    }
}
