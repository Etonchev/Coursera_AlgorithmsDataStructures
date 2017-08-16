using System;
using System.Collections.Generic;
using System.Linq;

namespace PointsSegments
{
    public class Segment
    {
        public long Start { get; set; }
        public long End { get; set; }
    }

    public enum SegmentPart
    {
        Start,
        End
    }

    class PointsSegments
    {
        public static long[] NaiveImplementation(Segment[] segments, long[] points)
        {
            var result = new long[points.LongLength];
            for (long i = 0; i < points.LongLength; i++)
            {
                var count = 0;
                foreach (var segment in segments)
                {
                    if (points[i] >= segment.Start && points[i] <= segment.End)
                    {
                        count++;
                    }
                }

                result[i] = count;
            }

            return result;
        }

        public static Dictionary<long, long> CalculateNumberOfInclusions(Segment[] segments, long[] points)
        {
            var pointInclusion = new Dictionary<long, long>();
            var pairs = new List<KeyValuePair<string, long>>();
            foreach (var segment in segments)
            {
                pairs.Add(new KeyValuePair<string, long>("left", segment.Start));
                pairs.Add(new KeyValuePair<string, long>("right", segment.End));
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
            var unclosedParenthesis = 0L;
            for (int i = 0; i < pairsSorted.Count; i++)
            {
                switch (pairsSorted[i].Key)
                {
                    case "left":
                        {
                            unclosedParenthesis++;
                            break;
                        }
                    case "right":
                        {
                            unclosedParenthesis--;
                            break;
                        }
                    case "point":
                        {
                            if (unclosedParenthesis > 0)
                            {
                                pointInclusion[pairsSorted[i].Value] = unclosedParenthesis;
                            }
                            else
                            {
                                pointInclusion[pairsSorted[i].Value] = 0;
                            }
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

        static void Main()
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
            var numberOfSegments = input[0];
            var segments = new Segment[numberOfSegments];
            for (long i = 0; i < numberOfSegments; i++)
            {
                input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                segments[i] = new Segment();
                segments[i].Start = input[0];
                segments[i].End = input[1];
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