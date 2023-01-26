using DemoUnitTest.ApiServices;
using DemoUnitTest.ServiceModel;
using DemoUnitTest.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoUnitTestTests
{
    public class GenderServiceTest
    {

        [Fact]
        public async Task GetGenderPrediction_NullName_Resturns_Null()
        {
            var genderApiServiceMock = new Mock<IGenderApiService>();
            genderApiServiceMock.Setup(x => x.GetGenderPrediction(It.IsAny<string>())).ReturnsAsync(new DemoUnitTest.ServiceModel.GenderPrediction());
            
            var genderService = new GenderService(genderApiServiceMock.Object);

            var actual = genderService.GetGenderPrediction(null);

            Assert.Null(actual);

        }
    }
}
