using System;

namespace MaximumLootValue
{
    public class LootItem
    {
        public int Value { get; set; }
        public int Weight { get; set; }
        public double ValuePerWeight { get; set; }
    }

    class MaximumLootValue
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var numberOfItems = int.Parse(input[0]);
            var capacity = int.Parse(input[1]);
            var lootItems = new LootItem[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                input = Console.ReadLine().Split(' ');
                lootItems[i] = new LootItem();
                lootItems[i].Value = int.Parse(input[0]);
                lootItems[i].Weight = int.Parse(input[1]);
                lootItems[i].ValuePerWeight = (double)lootItems[i].Value / lootItems[i].Weight;
            }

            var maximumLoot = CalculateMaximumLoot(capacity, lootItems);
            Console.WriteLine(maximumLoot);
        }

        private static double CalculateMaximumLoot(int capacity, LootItem[] lootItems)
        {
            var maximumLoot = 0d;
            Array.Sort(lootItems, (x, y) => y.ValuePerWeight.CompareTo(x.ValuePerWeight));
            foreach (var item in lootItems)
            {
                if(capacity == 0)
                {
                    break;
                }

                if(capacity < item.Weight)
                {
                    maximumLoot += capacity * item.ValuePerWeight;
                    capacity = 0;
                }
                else
                {
                    maximumLoot += item.Value;
                    capacity -= item.Weight;
                }
            }

            var roundedMaximumLoot = Math.Round(maximumLoot, 4);

            return roundedMaximumLoot;
        }
    }
}