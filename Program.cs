using System.Diagnostics;

namespace TheSeventhProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(FibonacciCalculation.CalculationFibonacciUsingTheRecursiveFunction(13));
            stopwatch.Stop();
            TimeSpan timeSpan1 = stopwatch.Elapsed;
            Console.WriteLine("Время вычисления чисел Фибоначчи с помощью рекурсивной функции составило- " + timeSpan1);
            stopwatch.Restart();
            Console.WriteLine(FibonacciCalculation.CalculationFibonacciUsingTheCyclicMethod(13));
            stopwatch.Stop();
            TimeSpan timeSpan2 = stopwatch.Elapsed;
            Console.WriteLine("Время вычисления чисел Фибоначчи с помощью циклов составило- " + timeSpan2);
        }
    }
}
