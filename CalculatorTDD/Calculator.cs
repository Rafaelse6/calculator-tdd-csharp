namespace CalculatorTDD
{
    public class Calculator
    {

        private List<string> historicList;
        private string data;

        public Calculator(string data)
        {
            historicList = new List<string>();
            this.data = data;
        }

        public int add(int val1, int val2)
        {
            int res = val1 + val2;

            historicList.Insert(0, "Res " + res + " - data: " + data);

            return res;
        }

        public int subtract(int val1, int val2)
        {
            int res = val1 - val2;

            historicList.Insert(0, "Res " + res + " - data: " + data);

            return res;
        }

        public int multiply(int val1, int val2)
        {
            int res = val1 * val2;

            historicList.Insert(0, "Res " + res + " - data: " + data);

            return res;
        }

        public int divide(int val1, int val2)
        {
            int res = val1 / val2;

            historicList.Insert(0, "Res " + res + " - data: " + data);

            return res;
        }

        public List<string> historic()
        {

            historicList.RemoveRange(3, historicList.Count - 3);
            return historicList;
        }
    }
}
