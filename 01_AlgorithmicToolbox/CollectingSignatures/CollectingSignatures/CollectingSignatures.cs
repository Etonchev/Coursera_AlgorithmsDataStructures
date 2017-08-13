using System;
using System.Collections.Generic;

namespace CollectingSignatures
{
    struct Line
    {
        public long startIndex { get; set; }
        public long endIndex { get; set; }
    }

    class CollectingSignatures
    {
        static void Main()
        {
            var numberOfSegments = int.Parse(Console.ReadLine());
            var lines = new Line[numberOfSegments];
            long[] input;
            for (int i = 0; i < numberOfSegments; i++)
            {
                input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                lines[i].startIndex = input[0];
                lines[i].endIndex = input[1];
            }

            var visitPoints = CalculateVisitPoints(lines);
            Console.WriteLine(visitPoints.Count);
            foreach (var point in visitPoints)
            {
                Console.Write($"{point} ");
            }
        }

        private static LinkedList<long> CalculateVisitPoints(Line[] lines)
        {
            var visitPoints = new LinkedList<long>();
            Array.Sort(lines, (x, y) => x.endIndex.CompareTo(y.endIndex));
            visitPoints.AddLast(lines[0].endIndex);
            for (int i = 1; i < lines.Length; i++)
            {
                if(visitPoints.Last.Value < lines[i].startIndex || visitPoints.Last.Value > lines[i].endIndex)
                {
                    visitPoints.AddLast(lines[i].endIndex);
                }
            }

            return visitPoints;
        }
    }
}