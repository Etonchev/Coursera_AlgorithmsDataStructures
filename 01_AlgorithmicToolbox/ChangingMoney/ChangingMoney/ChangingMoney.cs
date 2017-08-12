using System;
using System.Linq;

namespace ChangingMoney
{
    class ChangingMoney
    {
        static void Main()
        {
            var amount = int.Parse(Console.ReadLine());
            if(amount < 1 || amount > 1000)
            {
                throw new ArgumentException();
            }

            var availableCoins = new byte[]{ 10, 5, 1 };
            var minimumNumberOfCoins = CalculateMinimumNumberOfCoins(amount, availableCoins);
            Console.WriteLine(minimumNumberOfCoins);
        }

        private static byte CalculateMinimumNumberOfCoins(int amount, byte[] availableCoins)
        {
            availableCoins = availableCoins.OrderByDescending(c => c).ToArray();
            byte numberOfCoins = 0;
            foreach (var coin in availableCoins)
            {
                if(amount == 0)
                {
                    break;
                }

                numberOfCoins += (byte)(amount / coin);
                amount %= coin;
            }

            return numberOfCoins;
        }
    }
}