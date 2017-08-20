using System;

namespace KnapsackWithoutRepetition
{
    public class KnapsackWithoutRepetition
    {
        private static void Main()
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            var capacity = input[0];
            var goldBars = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            var knapsack = new Knapsack(capacity, goldBars);
            var maximumGold = knapsack.FindMaximumGold();
            Console.WriteLine(maximumGold);
        }

        public class Knapsack
        {
            public long[,] SolutionMatrix { get; set; }
            public long Capacity { get; set; }
            public long[] GoldBars { get; set; }

            public Knapsack(long capacity, long[] goldBars)
            {
                Capacity = capacity;
                GoldBars = goldBars;
                SolutionMatrix = new long[capacity + 1, goldBars.Length + 1];
            }

            public long FindMaximumGold()
            {
                var maximumGold = FindMaximumGoldRecursive(GoldBars, Capacity, 0);

                return maximumGold;
            }

            private long FindMaximumGoldRecursive(long[] goldBars, long capacity, long currentItemIndex)
            {
                if (currentItemIndex > goldBars.Length - 1)
                {
                    return 0;
                }

                if (capacity < goldBars[currentItemIndex])
                {
                    if (SolutionMatrix[capacity, currentItemIndex + 1] == 0)
                    {
                        SolutionMatrix[capacity, currentItemIndex + 1] = 
                            FindMaximumGoldRecursive(goldBars, capacity, currentItemIndex + 1);
                    }

                    return SolutionMatrix[capacity, currentItemIndex + 1];
                }

                if (SolutionMatrix[capacity, currentItemIndex + 1] == 0)
                {
                    SolutionMatrix[capacity, currentItemIndex + 1] =
                            FindMaximumGoldRecursive(goldBars, capacity, currentItemIndex + 1);
                }

                if (SolutionMatrix[capacity - goldBars[currentItemIndex], currentItemIndex + 1] == 0)
                {
                    SolutionMatrix[capacity - goldBars[currentItemIndex], currentItemIndex + 1] =
                        FindMaximumGoldRecursive(goldBars, capacity - goldBars[currentItemIndex], currentItemIndex + 1);
                }

                return Math.Max(SolutionMatrix[capacity, currentItemIndex + 1],
                    goldBars[currentItemIndex] + SolutionMatrix[capacity - goldBars[currentItemIndex], currentItemIndex + 1]);
            }
        }
    }
}