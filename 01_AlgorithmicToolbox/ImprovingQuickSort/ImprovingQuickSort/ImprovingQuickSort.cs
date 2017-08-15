using System;

namespace ImprovingQuickSort
{
    public static class ArrayExtensions
    {
        public static void QuickSort(this long[] array)
        {
            RecursiveQuickSort(array, 0, array.Length - 1);
        }

        private static void RecursiveQuickSort(long[] array, int left, int right)
        {
            if (left > right)
            {
                return;
            }

            var pivotIndexes = Partition(array, left, right);
            if (pivotIndexes.Item1 - 1 - left > 0)
            {
                RecursiveQuickSort(array, left, pivotIndexes.Item1 - 1);
            }
            if (right - pivotIndexes.Item2 + 1 > 0)
            {
                RecursiveQuickSort(array, pivotIndexes.Item2 + 1, right);
            }
        }

        private static Tuple<int, int> Partition(long[] array, int left, int right)
        {
            var pivot = CalculateMedian(ref array, left, right);
            var leftmost = left;
            var rightmost = right;
            var i = left;
            while (i <= rightmost) 
            {
                if (array[i] < pivot)
                {
                    Swap(array, i++, leftmost++);
                }
                else if (array[i] > pivot)
                {
                    Swap(array, i, rightmost--);
                }
                else
                {
                    i++;
                }
            }

            return new Tuple<int, int>(leftmost, rightmost);
        }

        private static long CalculateMedian(ref long[] array, int left, int right)
        {
            var middle = (left + right) / 2;
            if (array[left].CompareTo(array[middle]) == 1)
            {
                Swap(array, left, middle);
            }
            if (array[left].CompareTo(array[right]) == 1)
            {
                Swap(array, left, right);
            }
            if (array[middle].CompareTo(array[right]) == 1)
            {
                Swap(array, middle, right);
            }

            return array[middle];
        }

        private static void Swap(long[] array, int firstIndex, int secondIndex)
        {
            var previous = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = previous;
        }
    }

    class ImprovingQuickSort
    {
        static void Main()
        {
            var arraySize = int.Parse(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            array.QuickSort();
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}