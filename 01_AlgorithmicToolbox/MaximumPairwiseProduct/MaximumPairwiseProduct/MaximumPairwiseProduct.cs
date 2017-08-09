using System;

namespace MaximumPairwiseProduct
{
    class MaximumPairwiseProduct
    {
        static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            if(length < 2)
            {
                throw new ArgumentException("Invalid input!");
            }

            var input = Console.ReadLine().Split(' ');
            var array = Array.ConvertAll(input, int.Parse);

            var maximumPairwiseProduct = FindMaximumPairwiseProduct(array);
            Console.WriteLine(maximumPairwiseProduct);
        }

        private static long FindMaximumPairwiseProduct(int[] array)
        {
            var firstMaxElementIndex = 0;
            var secondMaxElementIndex = 0;
            var length = array.Length;

            for (int i = 1; i < length; i++)
            {
                if(array[i] > array[firstMaxElementIndex])
                {
                    firstMaxElementIndex = i;
                }
            }

            if(firstMaxElementIndex == secondMaxElementIndex)
            {
                secondMaxElementIndex++;
            }

            for (int i = 1; i < length; i++)
            {
                if (array[i] > array[secondMaxElementIndex] && i != firstMaxElementIndex)
                {
                    secondMaxElementIndex = i;
                }
            }

            var maximumPairwiseProduct = (long)array[firstMaxElementIndex] * array[secondMaxElementIndex];

            return maximumPairwiseProduct;
        }
    }
}