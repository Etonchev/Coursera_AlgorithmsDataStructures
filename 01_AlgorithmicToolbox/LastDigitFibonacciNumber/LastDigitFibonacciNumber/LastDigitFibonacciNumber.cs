using System;

namespace LastDigitFibonacciNumber
{
    class LastDigitFibonacciNumber
    {
        static void Main()
        {
            var fibonacciIndex = long.Parse(Console.ReadLine());
            if (fibonacciIndex < 0)
            {
                throw new ArgumentException("Invalid argument!");
            }

            var lastDigitFibonacciNumber = CalculateLastDigitFibonacciNumber(fibonacciIndex);
            Console.WriteLine(lastDigitFibonacciNumber);
        }

        private static byte CalculateLastDigitFibonacciNumber(long fibonacciIndex)
        {
            byte firstFibonacciNumber = 0;
            byte secondFibonacciNumber = 1;
            if (fibonacciIndex == 0)
            {
                return firstFibonacciNumber;
            }

            while(fibonacciIndex > 1)
            {
                var previous = secondFibonacciNumber;
                secondFibonacciNumber = (byte)((secondFibonacciNumber + firstFibonacciNumber) % 10);
                firstFibonacciNumber = previous;
                fibonacciIndex--;
            }

            return secondFibonacciNumber;
        }
    }
}