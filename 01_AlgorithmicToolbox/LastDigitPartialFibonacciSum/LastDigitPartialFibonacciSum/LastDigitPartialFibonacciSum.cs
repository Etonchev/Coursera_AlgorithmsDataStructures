using System;

namespace LastDigitPartialFibonacciSum
{
    class LastDigitPartialFibonacciSum
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var startIndex = long.Parse(input[0]);
            var endIndex = long.Parse(input[1]);
            if (startIndex > endIndex)
            {
                throw new ArgumentException();
            }

            var lastDigit = CalculateLastDigitPartialSumFibonacci(startIndex, endIndex);
            Console.WriteLine(lastDigit);
        }

        private static byte CalculateLastDigitPartialSumFibonacci(long startIndex, long endIndex)
        {
            var wholeRangeSum = CalculateLastDigitsSumFibonacciNumber(endIndex, 100);
            if(startIndex == 0)
            {
                return (byte)(wholeRangeSum % 10);
            }
            if(wholeRangeSum == 0)
            {
                wholeRangeSum = 100;
            }

            var excluded = CalculateLastDigitsSumFibonacciNumber(startIndex - 1, 10);
            if(excluded == 0)
            {
                excluded = 10;
            }

            var partialSum = (byte)((wholeRangeSum - excluded) % 10);

            return partialSum;
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
    }
}