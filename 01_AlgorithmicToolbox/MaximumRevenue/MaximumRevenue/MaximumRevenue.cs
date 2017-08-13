using System;

namespace MaximumRevenue
{
    class MaximumRevenue
    {
        public static int CompareByAbs(long x, long y)
        {
            var signOfX = Math.Sign(x);
            var signOfY = Math.Sign(y);
            if (signOfX == -1 && signOfY == -1)
            {
                return Math.Abs(y).CompareTo(Math.Abs(x));
            }
            else if(signOfX == 1 && signOfY == 1)
            {
                return Math.Abs(x).CompareTo(Math.Abs(y));
            }
            else if (signOfX > signOfY)
            {
                return 1;
            }

            return -1;
        }
        static void Main()
        {
            var length = long.Parse(Console.ReadLine());
            var profits = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            var clicks = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            Array.Sort(profits, CompareByAbs);
            Array.Sort(clicks, CompareByAbs);
            var maximumRevenue = 0L;
            for (long i = 0; i < length; i++)
            {
                maximumRevenue += profits[i] * clicks[i];
            }

            Console.WriteLine(maximumRevenue);
        }
    }
}