using System;

namespace MajorityElement
{
    class MajorityElement
    {
        static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            var majorityCandidate = FindMajorityCandidate(input);
            var majorityCandidateCount = 0L;
            foreach (var number in input)
            {
                if (number == majorityCandidate)
                {
                    majorityCandidateCount++;
                }
            }

            if (majorityCandidateCount > size / 2)
            {
                Console.WriteLine(1);
                return;
            }

            Console.WriteLine(0);
        }

        //Boyer–Moore majority vote algorithm
        private static long FindMajorityCandidate(long[] array)
        {
            var majorityIndex = 0;
            var count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[majorityIndex])
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if (count == 0)
                {
                    count = 1;
                    majorityIndex = i;
                }
            }

            return array[majorityIndex];
        }
    }
}