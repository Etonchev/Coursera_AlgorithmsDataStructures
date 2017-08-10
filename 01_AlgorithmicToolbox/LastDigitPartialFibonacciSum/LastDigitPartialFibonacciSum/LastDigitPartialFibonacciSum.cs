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
            var startIndexModulo = 10;
            var endIndexModulo = 100;
            var startIndexPisanoPeriod = CalculatePisanoPeriod(startIndexModulo);
            var endIndexPisanoPeriod = CalculatePisanoPeriod(endIndexModulo);

            //Using the pisano period we lower the value for start and end index
            var smallerStartIndex = startIndex - 1;
            var smallerEndIndex = endIndex;
            if (smallerStartIndex >= 2)
            {
                smallerStartIndex %= startIndexPisanoPeriod;
            }
            if (smallerEndIndex >= 2)
            {
                smallerEndIndex %= endIndexPisanoPeriod;
            }


            var wholeRangeSum = CalculateLastDigitsSumFibonacciNumber(smallerEndIndex, endIndexModulo);
            if(smallerStartIndex == 0)
            {
                return (byte)(wholeRangeSum % 10);
            }
            //3-digit Fibonacci numbers start from index 10
            if(wholeRangeSum == 0 && smallerEndIndex > 10)
            {
                wholeRangeSum = 100;
            }

            var excluded = CalculateLastDigitsSumFibonacciNumber(smallerStartIndex, startIndexModulo);
            //2-digit Fibonacci numbers start from index 5
            if(excluded == 0 && smallerStartIndex > 5)
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