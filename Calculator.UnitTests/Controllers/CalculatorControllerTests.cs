using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Controllers;
using Calculator.Interfaces;
using Calculator.Models;
using Moq;
using Xunit;

namespace Calculator.UnitTests.Controllers
{
    public class CalculatorControllerTests
    {
        private readonly Mock<ICalculate> _mockCalculate;
        private readonly CalculatorController _mockCalculatorController;
        private readonly ResistorValuesModel _mockResistorValues;
        public CalculatorControllerTests()
        {
            _mockCalculate = new Mock<ICalculate>();
            _mockCalculatorController = new CalculatorController(_mockCalculate.Object);
            _mockResistorValues = new ResistorValuesModel()
            {
                Band1 = 2,
                Band2 = 2,
                Multiplier = 100M,
                Tolerance = 0.02M
            };

        }

        [Fact]
        public void Calculate_ReturnsString_Test()
        {
            _mockCalculate
                .Setup(x => x.CalculateOhmValue(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<decimal>(), It.IsAny<decimal>()))
                .Returns("Any String");

            var result = _mockCalculatorController.Calculate(_mockResistorValues);
            Assert.IsType<string>(result);
        }
        [Fact]
        public void Calculate_ReturnsBadRequest_OnNullInput_Test()
        {
            var result = _mockCalculatorController.Calculate(null);
            Assert.Equal("Bad Request", result);
        }


    }
}
