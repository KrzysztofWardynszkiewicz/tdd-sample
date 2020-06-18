using Calculator;
using Moq;
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

        [Fact]
        public void ReadTest()
        {
            var memoryMock = new Mock<IMemory<double>>();
            memoryMock.Setup(x => x.Read()).Returns(5);

            Calculator.Calculator sut = new Calculator.Calculator(memoryMock.Object);
            var result = sut.GetStored();

            Assert.Equal(5, result);
            memoryMock.Verify(x => x.Read());
        }
    }
}
