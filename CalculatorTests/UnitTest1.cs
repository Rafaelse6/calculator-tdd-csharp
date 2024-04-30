using CalculatorTDD;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void AddTest(int val1, int val2, int result)
        {
            Calculator calc = new Calculator();

            int resultCalculator = calc.add(val1, val2);

            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void MultiplicationTest(int val1, int val2, int result)
        {
            Calculator calc = new Calculator();

            int resultCalculator = calc.multiply(val1, val2);

            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void DivisonTest(int val1, int val2, int result)
        {
            Calculator calc = new Calculator();

            int resultCalculator = calc.divide(val1, val2);

            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void SubtractionTest(int val1, int val2, int result)
        {
            Calculator calc = new Calculator();

            int resultCalculator = calc.subtract(val1, val2);

            Assert.Equal(result, resultCalculator);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            Calculator calc = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calc.divide(3, 0));
        }
    }
}