using Calculator.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.UnitTests.Logic
{
    public class CalculateTests
    {
        private readonly Calculate _calculate;
        public CalculateTests()
        {
            _calculate = new Calculate();
        }
        [Theory]
        [InlineData(-1, 2, 100, 5)]
        public void CalculateOhmsValue_InvalidParam1_Test(int band1, int band2, decimal multiplier, decimal tolerance)
        {
            Assert.Equal("Invalid Parameters", _calculate.CalculateOhmValue(band1, band2, multiplier, tolerance));
        }

        [Theory]
        [InlineData(0, -1, 100, 5)]
        public void CalculateOhmsValue_InvalidParam2_Test(int band1, int band2, decimal multiplier, decimal tolerance)
        {
            Assert.Equal("Invalid Parameters", _calculate.CalculateOhmValue(band1, band2, multiplier, tolerance));
        }

        [Theory]
        [InlineData(0, 1, -1, 5)]
        public void CalculateOhmsValue_InvalidParam3_Test(int band1, int band2, decimal multiplier, decimal tolerance)
        {
            Assert.Equal("Invalid Parameters", _calculate.CalculateOhmValue(band1, band2, multiplier, tolerance));
        }

        [Theory]
        [InlineData(0, 1, 100, -1)]
        public void CalculateOhmsValue_InvalidParam4_Test(int band1, int band2, decimal multiplier, decimal tolerance)
        {
            Assert.Equal("Invalid Parameters", _calculate.CalculateOhmValue(band1, band2, multiplier, tolerance));
        }

        [Theory]
        [InlineData(-1, -1, -1, -1)]
        public void CalculateOhmsValue_InvalidParam5_Test(int band1, int band2, decimal multiplier, decimal tolerance)
        {
            Assert.Equal("Invalid Parameters", _calculate.CalculateOhmValue(band1, band2, multiplier, tolerance));
        }

        [Theory]
        [InlineData(1,2,100, 5)]
        public void CalculateOhmsValue_ReturnsValidOutput1_Test(int band1, int band2, decimal multiplier, decimal tolerance)
        {
            Assert.Equal("1.2K Ohms ±5%", _calculate.CalculateOhmValue(band1, band2, multiplier, tolerance));
        }

        [Theory]
        [InlineData(2, 1, 100000, 2)]
        public void CalculateOhmsValue_ReturnsValidOutput2_Test(int band1, int band2, decimal multiplier, decimal tolerance)
        {
            Assert.Equal("2.1M Ohms ±2%", _calculate.CalculateOhmValue(band1, band2, multiplier, tolerance));
        }

        [Theory]
        [InlineData(9, 9, 1000000000, 0.02)]
        public void CalculateOhmsValue_ReturnsValidOutput3_Test(int band1, int band2, decimal multiplier, decimal tolerance)
        {
            Assert.Equal("99G Ohms ±0.02%", _calculate.CalculateOhmValue(band1, band2, multiplier, tolerance));
        }

        [Theory]
        [InlineData(0, 0, 1, 1)]
        public void CalculateOhmsValue_ReturnsValidOutput4_Test(int band1, int band2, decimal multiplier, decimal tolerance)
        {
            Assert.Equal("0 Ohms ±1%", _calculate.CalculateOhmValue(band1, band2, multiplier, tolerance));
        }
    }
}
