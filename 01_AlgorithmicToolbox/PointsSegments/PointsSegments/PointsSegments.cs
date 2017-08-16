using System;
using System.Collections.Generic;
using System.Linq;

namespace PointsSegments
{
    class PointsSegments
    {
        public static Dictionary<long, long> CalculateNumberOfInclusions(Segment[] segments, long[] points)
        {
            var pointInclusion = new Dictionary<long, long>();
            var pairs = new List<KeyValuePair<string, long>>();
            foreach (var segment in segments)
            {
                pairs.Add(new KeyValuePair<string, long>("left", segment.Left));
                pairs.Add(new KeyValuePair<string, long>("right", segment.Right));
            }
            foreach (var point in points)
            {
                pairs.Add(new KeyValuePair<string, long>("point", point));
                if (!pointInclusion.ContainsKey(point))
                {
                    pointInclusion.Add(point, 0);
                }
            }

            var pairsSorted = pairs.OrderBy(p => p.Value).ThenBy(p => p.Key).ToList();
            var unclosedSegments = 0L;
            foreach (var pair in pairsSorted)
            {
                switch (pair.Key)
                {
                    case "left":
                    {
                        unclosedSegments++;
                        break;
                    }
                    case "right":
                    {
                        unclosedSegments--;
                        break;
                    }
                    case "point":
                    {
                        pointInclusion[pair.Value] = unclosedSegments;
                        break;
                    }
                    default:
                    {
                        throw new Exception("Invalid pair");
                    }
                }
            }

            return pointInclusion;
        }

        public class Segment
        {
            public long Left { get; set; }
            public long Right { get; set; }

            public Segment(long left, long right)
            {
                Left = left;
                Right = right;
            }
        }

        private static void Main()
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            var numberOfSegments = input[0];
            var segments = new Segment[numberOfSegments];
            for (long i = 0; i < numberOfSegments; i++)
            {
                input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                segments[i] = new Segment(left: input[0], right: input[1]);
            }

            var points = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            var result = CalculateNumberOfInclusions(segments, points);
            foreach (var point in points)
            {
                Console.Write($"{result[(int)point]} ");
            }
        }
    }
}