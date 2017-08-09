using System;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var firstNumber = long.Parse(input[0]);
            var secondNumber = long.Parse(input[1]);
            if(firstNumber <= 0 || secondNumber <= 0)
            {
                throw new ArgumentException();
            }

            var greatestCommonDivisor = CalculateGreatestCommonDivisor(firstNumber, secondNumber);
            Console.WriteLine(greatestCommonDivisor);
        }

        private static long CalculateGreatestCommonDivisor(long firstNumber, long secondNumber)
        {
            if(secondNumber > firstNumber)
            {
                firstNumber += secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber = firstNumber - secondNumber;
            }

            while(secondNumber != 0)
            {
                var previous = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = previous;
            }

            return firstNumber;
        }
    }
}