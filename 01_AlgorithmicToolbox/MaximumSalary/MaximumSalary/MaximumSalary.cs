using System;
using System.Text;

namespace MaximumSalary
{
    class MaximumSalary
    {
        static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            var numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(numbers, CompareGluedNumbers);
            StringBuilder maximumSalary = new StringBuilder();
            foreach (var number in numbers)
            {
                maximumSalary.Append(number.ToString());
            }

            Console.WriteLine(maximumSalary);
        }

        public static int CompareGluedNumbers(int first, int second)
        {
            if (first == second)
            {
                return 0;
            }

            if (first / 10 < 1 && second / 10 < 1)
            {
                return second.CompareTo(first);
            }

            var firstGluedToSecond = long.Parse(first.ToString() + second.ToString());
            var secondGluedToFirs = long.Parse(second.ToString() + first.ToString());

            if (firstGluedToSecond < secondGluedToFirs)
            {
                return 1;
            }

            return -1;
        }
    }
}