using CalculatorTDD;

namespace CalculatorTests
{
    public class UnitTest1
    {

        public Calculator buildClass()
        {
            string data = "02/02/2020";

            Calculator calc = new Calculator("02/02/2020");

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void AddTest(int val1, int val2, int result)
        {
            Calculator calc = buildClass();

            int resultCalculator = calc.add(val1, val2);

            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void MultiplicationTest(int val1, int val2, int result)
        {
            Calculator calc = buildClass();

            int resultCalculator = calc.multiply(val1, val2);

            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void DivisonTest(int val1, int val2, int result)
        {
            Calculator calc = buildClass();

            int resultCalculator = calc.divide(val1, val2);

            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void SubtractionTest(int val1, int val2, int result)
        {
            Calculator calc = buildClass();

            int resultCalculator = calc.subtract(val1, val2);

            Assert.Equal(result, resultCalculator);
        }

        [Fact]
        public void TestDivisionByZero()
        {
            Calculator calc = buildClass();

            Assert.Throws<DivideByZeroException>(() => calc.divide(3, 0));
        }

        [Fact]
        public void TestHistoric()
        {
            Calculator calc = buildClass();

            calc.add(1, 2);
            calc.add(2, 8);
            calc.add(3, 7);
            calc.add(4, 1);

            var resultList = calc.historic();

            Assert.NotEmpty(resultList);
            Assert.Equal(3, resultList.Count);
        }
    }
}