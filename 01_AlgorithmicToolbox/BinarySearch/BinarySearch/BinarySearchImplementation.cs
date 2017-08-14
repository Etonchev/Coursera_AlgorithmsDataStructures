using System;
using System.Linq;

namespace BinarySearch
{
    class BinarySearchImplementation
    {
        static void Main()
        {
            var sortedArray = Array.ConvertAll(Console.ReadLine().Split(' ').Skip(1).ToArray(), long.Parse);
            var searchItems = Array.ConvertAll(Console.ReadLine().Split(' ').Skip(1).ToArray(), long.Parse);
            var results = BinarySearchArray(sortedArray, searchItems);
            foreach (var result in results)
            {
                Console.Write($"{result} ");
            }
        }

        public static int[] BinarySearchArray(long[] array, long[] searchItems)
        {
            var result = new int[searchItems.Length];
            for (int i = 0; i < searchItems.Length; i++)
            {
                result[i] = BinarySearch(array, searchItems[i]);
            }

            return result;
        }

        public static int BinarySearch(long[] array, long item)
        {
            var start = 0;
            var end = array.Length - 1;

            while (start <= end)
            {
                var middle = Convert.ToInt32(Math.Floor((decimal)(start + end) / 2));
                if (array[middle] == item)
                {
                    return middle;
                }

                if (array[middle] < item)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }

            return -1;
        }
    }
}