using Moq;
using System;
using UnitTestJune5Demo;
using Xunit;

namespace XUnitTestProject1
{
    // test bittiğinde saat 07:40 hdef.
    public class InflationServiceTest
    {
        private Mock<IMyLogger> _mockLog;
        private Mock<IInflationRate> _mockRate;

        InflationService _service;
        public InflationServiceTest()
        {
            _mockLog = new Mock<IMyLogger>(MockBehavior.Loose);
            _mockRate = new Mock<IInflationRate>(MockBehavior.Loose);
            _service = new InflationService(_mockRate.Object, _mockLog.Object);
        }

        [Theory]
        [InlineData(1000, 2020, 1100, 0.1)]
        public void GetAmountByYear_WhenValidAmountAndYear_ReturnValidAmount
            (double amount, int year, double expectedAmount, double rate)
        {

            _mockRate.Setup(x => x.Rate(year)).Returns(rate);
            var actualAmount = _service.GetAmountByYear(amount, year);

            Assert.Equal(expectedAmount, actualAmount);

           _mockLog.Verify(x => x.Log(It.IsAny<string>()), Times.Exactly(3));

        }
    }
}
