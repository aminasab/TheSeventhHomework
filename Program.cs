using System.Diagnostics;

namespace TheSeventhProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            string stringOfUsingTheRecursiveFunction = "Время вычисления чисел Фибоначчи с помощью рекурсивной функции составило - ";
            string stringOfUsingTheCyclicMethod = "Время вычисления чисел Фибоначчи с помощью циклов составило- ";
            string numberOfFibonacci = "Число Фибоначчи от ";
            int[] numbers = { 5, 10, 20 };
            for (int i = 0; i < 3; i++)
            {
                stopwatch.Start();
                Console.WriteLine(numberOfFibonacci + numbers[i] + " : " + FibonacciCalculation.CalculationFibonacciUsingTheRecursiveFunction(numbers[i]));
                stopwatch.Stop();
                TimeSpan timeSpan1 = stopwatch.Elapsed;
                Console.WriteLine(stringOfUsingTheRecursiveFunction + timeSpan1);
                stopwatch.Restart();
                FibonacciCalculation.CalculationFibonacciUsingTheCyclicMethod(numbers[i]);
                stopwatch.Stop();
                TimeSpan timeSpan2 = stopwatch.Elapsed;
                Console.WriteLine(stringOfUsingTheCyclicMethod + timeSpan2);
            }
        }
    }
}
