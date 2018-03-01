using UnitTests.Services;
using Xunit;
using NSubstitute;

namespace UnitTests.Tests
{
    public class ServiceATests
    {
        [Fact]
        public void Test_SumServiceBAndParamterValue_CallsServiceBOnes()
        {
            var serviceBMock = Substitute.For<IServiceB>();
            var service = new ServiceA(serviceBMock);

            service.SumServiceBAndParamterValue(10, 20);

            serviceBMock.Received(1).GetValue(10);
        }

        [Fact]
        public void Test_SumServiceBAndParamterValues_ReturnsSumOfServiceBAndParameterValue()
        {
            var serviceBMock = Substitute.For<IServiceB>();
            var service = new ServiceA(serviceBMock);

            serviceBMock.GetValue(10).Returns(3);

            var result = service.SumServiceBAndParamterValue(10, 20);
            
            Assert.Equal(23, result);
        }

    }
}
