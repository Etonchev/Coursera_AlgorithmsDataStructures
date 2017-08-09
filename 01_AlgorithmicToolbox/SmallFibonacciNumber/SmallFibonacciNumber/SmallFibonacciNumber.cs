using System;

namespace SmallFibonacciNumber
{
    class SmallFibonacciNumber
    {
        static void Main()
        {
            var fibonacciIndex = int.Parse(Console.ReadLine());
            if(fibonacciIndex < 0)
            {
                throw new ArgumentException("Invalid argument!");
            }

            var fibonacciNumber = CalculateFibonacciNumber(fibonacciIndex);
            Console.WriteLine(fibonacciNumber);
        }

        private static long CalculateFibonacciNumber(int fibonacciIndex)
        {
            long firstFibonacciNumber = 0;
            long secondFibonacciNumber = 1;
            if(fibonacciIndex == 0)
            {
                return firstFibonacciNumber;
            }

            if(firstFibonacciNumber == 1)
            {
                return secondFibonacciNumber;
            }

            while(fibonacciIndex > 1)
            {
                var previous = secondFibonacciNumber;
                secondFibonacciNumber += firstFibonacciNumber;
                firstFibonacciNumber = previous;
                fibonacciIndex--;
            }

            return secondFibonacciNumber;
        }
    }
}