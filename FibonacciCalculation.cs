namespace TheSeventhProgram
{
    internal class FibonacciCalculation
    {
        internal static int CalculationFibonacciUsingTheRecursiveFunction(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return CalculationFibonacciUsingTheRecursiveFunction(n - 1) + CalculationFibonacciUsingTheRecursiveFunction(n - 2);
        }

        public static int CalculationFibonacciUsingTheCyclicMethod(int n)
        {
            int result = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }
            return result;
        }
    }
}
