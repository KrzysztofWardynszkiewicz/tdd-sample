using Calculator;
using Moq;
using System;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(1, 2, 3)]
        public void SumTest(double arg1, double arg2, double expected)
        {
            var memoryMock = new Mock<IMemory<double>>();

            Calculator.Calculator sut = new Calculator.Calculator(memoryMock.Object);
            sut.Sum(arg1, arg2);

            memoryMock.Verify(x => x.Store(expected));
        }
    }
}
