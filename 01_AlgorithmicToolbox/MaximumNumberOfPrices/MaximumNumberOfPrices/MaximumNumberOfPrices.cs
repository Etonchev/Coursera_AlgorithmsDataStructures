using System;
using System.Collections.Generic;

namespace MaximumNumberOfPrices
{
    class MaximumNumberOfPrices
    {
        static void Main()
        {
            var prices = long.Parse(Console.ReadLine());
            var addends = new List<long>();
            var addend = 1;
            while (addend * 2 < prices)
            {
                addends.Add(addend);
                prices -= addend;
                addend++;
            }

            addends.Add(prices);
            Console.WriteLine(addends.Count);
            foreach (var integer in addends)
            {
                Console.Write($"{integer} ");
            }
        }
    }
}