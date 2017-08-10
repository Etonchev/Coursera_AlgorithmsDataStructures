using System;

namespace FibonacciNumberModulo
{
    class FibonacciNumberModulo
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var fibonacciIndex = long.Parse(input[0]);
            var modulo = long.Parse(input[1]);
            if (fibonacciIndex < 1 || modulo < 2)
            {
                throw new ArgumentException();
            }

            var pisanoPeriod = CalculateFibonacciNumberModulo(modulo * modulo, modulo, true).PisanoPeriod;
            var remainder = fibonacciIndex % pisanoPeriod;
            var fibonacciModulo = CalculateFibonacciNumberModulo(remainder, modulo, false).FibonacciNumber;
            Console.WriteLine(fibonacciModulo);
        }

        private static Fibonacci CalculateFibonacciNumberModulo(long fibonacciIndex, long modulo, bool breakOnPisanoPeriod)
        {
            long firstFibonacciNumber = 0;
            long secondFibonacciNumber = 1;
            var pisanoPeriod = 0;
            if (fibonacciIndex == 0)
            {
                return new Fibonacci(firstFibonacciNumber, pisanoPeriod);
            }

            for (int i = 1; i < fibonacciIndex; i++)
            {
                var previous = secondFibonacciNumber;
                secondFibonacciNumber = (secondFibonacciNumber + firstFibonacciNumber) % modulo;
                firstFibonacciNumber = previous;
                if (firstFibonacciNumber == 0 && secondFibonacciNumber == 1 && breakOnPisanoPeriod)
                {
                    pisanoPeriod = i;
                    break;
                }
            }

            return new Fibonacci(secondFibonacciNumber, pisanoPeriod);
        }

        public class Fibonacci
        {
            public long FibonacciNumber { get; set; }
            public long PisanoPeriod { get; set; }

            public Fibonacci(long fibonacciNumber, long pisanoPeriod)
            {
                FibonacciNumber = fibonacciNumber;
                PisanoPeriod = pisanoPeriod;
            }
        }
    }
}