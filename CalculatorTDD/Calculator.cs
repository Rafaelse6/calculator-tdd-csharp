namespace CalculatorTDD
{
    public class Calculator
    {
        public int add(int val1, int val2)
        {
            int res = val1 + val2;
            return res;
        }

        public int subtract(int val1, int val2)
        {
            int res = val1 - val2;
            return res;
        }

        public int multiply(int val1, int val2)
        {
            int res = val1 * val2;
            return res;
        }

        public int divide(int val1, int val2)
        {
            int res = val1 / val2;
            return res;
        }

        public List<string> historic()
        {
            return new List<string>();
        }
    }
}
