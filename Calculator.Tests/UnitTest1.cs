using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectValue()
        {
            Assert.Equal(8, CalculatorService.Add(5, 2));
        }

        [Fact]
        public void Sub_ReturnsCorrectValue()
        {
            Assert.Equal(2, CalculatorService.Sub(5, 3));
        }

        [Fact]
        public void Mul_ReturnsCorrectValue()
        {
            Assert.Equal(15, CalculatorService.Mul(3, 5));
        }

        [Fact]
        public void Div_ReturnsCorrectValue()
        {
            Assert.Equal(2.5, CalculatorService.Div(5, 2));
        }

        [Fact]
        public void Div_ThrowsWhenDividingByZero()
        {
            Assert.Throws<DivideByZeroException>(() => CalculatorService.Div(5, 0));
        }
    }
}
