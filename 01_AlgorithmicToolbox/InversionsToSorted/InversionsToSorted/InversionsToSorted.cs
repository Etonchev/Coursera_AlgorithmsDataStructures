using System;

namespace InversionsToSorted
{
    class InversionsToSorted
    {
        public static long MergeSort(long[] array)
        {
            var inversions = MergeSortRecursive(array, 0, array.Length - 1);

            return inversions;
        }

        public static long MergeSortRecursive(long[] array, long left, long right)
        {
            long inversions = 0;
            if (left < right)
            {
                long middle = (left + right) / 2;
                inversions = MergeSortRecursive(array, left, middle);
                inversions += MergeSortRecursive(array, middle + 1, right);
                inversions += PerformMerge(array, left, middle, right);
            }

            return inversions;
        }

        public static long PerformMerge(long[] array, long left, long middle, long right)
        {
            var inversions = 0L;
            var firstLength = middle - left + 1;
            var secondLength = right - middle;
            long[] firstArray = new long[firstLength + 1];
            long[] secondArray = new long[secondLength + 1];

            for (long i = 0; i < firstLength; i++)
            {
                firstArray[i] = array[left + i];
            }
            for (long j = 0; j < secondLength; j++)
            {
                secondArray[j] = array[middle + 1 + j];
            }

            //When one of the arrays becomes empty, before the other, the remaining elements will be compared with MaxValue
            firstArray[firstLength] = Int64.MaxValue;
            secondArray[secondLength] = Int64.MaxValue;

            for (long k = left, i = 0, j = 0; k <= right; k++)
            {
                if (firstArray[i] <= secondArray[j])
                {
                    array[k] = firstArray[i];
                    i++;
                }
                else
                {
                    array[k] = secondArray[j];
                    j++;
                    inversions += firstLength - i;
                }
            }

            return inversions;
        }

        static void Main()
        {
            var arraySize = long.Parse(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            var inversions = MergeSort(array);
            Console.WriteLine(inversions);
        }
    }
}