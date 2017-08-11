using System;

namespace LastDigitFibonacciSum
{
    class LastDigitFibonacciSum
    {
        static void Main()
        {
            var lastIndex = long.Parse(Console.ReadLine());
            if (lastIndex < 0)
            {
                throw new ArgumentException();
            }

            var lastDigit = CalculateLastDigitSumFibonacci(lastIndex);
            Console.WriteLine(lastDigit);
        }

        private static byte CalculateLastDigitSumFibonacci(long lastIndex)
        {
            var indexModulo = 10;
            var indexPisanoPeriod = CalculatePisanoPeriod(indexModulo);

            //Using the pisano period we lower the value for the index
            if (lastIndex >= 2)
            {
                lastIndex %= indexPisanoPeriod;
            }

            var fibonacciSum = CalculateLastDigitsSumFibonacciNumber(lastIndex, indexModulo);

            return fibonacciSum;
        }

        private static byte CalculateLastDigitsSumFibonacciNumber(long fibonacciIndex, int modulo)
        {
            byte firstFibonacciNumber = 0;
            byte secondFibonacciNumber = 1;
            byte lastDigitSum = 1;
            if (fibonacciIndex == 0)
            {
                return 0;
            }

            while (fibonacciIndex > 1)
            {
                var previous = secondFibonacciNumber;
                secondFibonacciNumber = (byte)((secondFibonacciNumber + firstFibonacciNumber) % modulo);
                firstFibonacciNumber = previous;
                fibonacciIndex--;
                lastDigitSum += secondFibonacciNumber;
                lastDigitSum %= (byte)modulo;
            }

            return lastDigitSum;
        }

        private static long CalculatePisanoPeriod(long modulo)
        {
            long firstFibonacciNumber = 0;
            long secondFibonacciNumber = 1;
            var pisanoPeriod = 0;

            for (int i = 1; i < modulo * modulo; i++)
            {
                var previous = secondFibonacciNumber;
                secondFibonacciNumber = (secondFibonacciNumber + firstFibonacciNumber) % modulo;
                firstFibonacciNumber = previous;
                if (firstFibonacciNumber == 0 && secondFibonacciNumber == 1)
                {
                    pisanoPeriod = i;
                    break;
                }
            }

            return pisanoPeriod;
        }
    }
}