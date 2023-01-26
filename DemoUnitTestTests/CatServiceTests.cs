using DemoUnitTest.ApiServices;
using DemoUnitTest.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DemoUnitTestTests
{
    public class CatServiceTests
    {
        [Fact]
        public async void GetCatFact_With_MaxLength_Zero_Returns_CatFact()
        {
            //Arrange
            var catApiSerbviceMock = new Mock<ICatsApiService>();
            catApiSerbviceMock.Setup(serv => serv.GetCatFact()).ReturnsAsync(new DemoUnitTest.ServiceModel.CatFact() { Fact = "Test fact", Length = 9 });
            var catService = new CatService(catApiSerbviceMock.Object);
            var expectedResult = new DemoUnitTest.ServiceModel.CatFact() { Fact = "Test fact", Length = 9 };
            var maxLenghtDefault = 0;
            //Act
            var actualResult = await catService.GetCatFact(maxLenghtDefault);
            //Assert
            Assert.Equal(expectedResult.Length, actualResult.Length);
            Assert.Equal(expectedResult.Fact, actualResult.Fact);
        }

        [Fact]
        public async void GetCatFact_With_MaxLength_HigherThanZero_Returns_CatFact_HigherThanZero()
        {
            //Arrange
            var catApiSerbviceMock = new Mock<ICatsApiService>();
            catApiSerbviceMock.Setup(serv => serv.GetCatFact()).ReturnsAsync(new DemoUnitTest.ServiceModel.CatFact() { Fact = "Test fact", Length = 9 });
            var catService = new CatService(catApiSerbviceMock.Object);
            var expectedResult = new DemoUnitTest.ServiceModel.CatFact() { Fact = "Test fact", Length = 9 };
            var maxLenghtDefault = 10;
            //Act
            var actualResult = await catService.GetCatFact(maxLenghtDefault);
            //Assert
            Assert.Equal(expectedResult.Length, actualResult.Length);
            Assert.Equal(expectedResult.Fact, actualResult.Fact);
        }

        [Fact]
        public async void GetCatFact_With_MaxLength_HigherThanZero_Returns_CatFact_Null()
        {
            //Arrange
            var catApiSerbviceMock = new Mock<ICatsApiService>();
            catApiSerbviceMock.Setup(serv => serv.GetCatFact()).ReturnsAsync(new DemoUnitTest.ServiceModel.CatFact() { Fact = "Test fact", Length = 9 });
            var catService = new CatService(catApiSerbviceMock.Object);
            var expectedResult = new DemoUnitTest.ServiceModel.CatFact() { Fact = "Test fact", Length = 9 };
            var maxLenghtDefault = 8;
            //Act
            var actualResult = await catService.GetCatFact(maxLenghtDefault);
            //Assert
            Assert.Null(actualResult);
        }
    }
}
