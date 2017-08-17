using System;
using System.Collections.Generic;
using System.Linq;

namespace FindClosestPairOfPoints
{
    class FindClosestPairOfPoints
    {
        public class Point
        {
            public const int Precision = 6;
            public long XCoordinate { get; set; }
            public long YCoordinate { get; set; }

            public Point(long x, long y)
            {
                XCoordinate = x;
                YCoordinate = y;
            }

            public static decimal CalculateDistance(Point firstPoint, Point secondPoint)
            {
                var distance = (decimal)Math.Sqrt((firstPoint.XCoordinate - secondPoint.XCoordinate) * (firstPoint.XCoordinate - secondPoint.XCoordinate) +
                    (firstPoint.YCoordinate - secondPoint.YCoordinate) * (firstPoint.YCoordinate - secondPoint.YCoordinate));
                var precisionCoefficient = Convert.ToDecimal(Math.Pow(10, Precision));
                var truncatedDistance = Math.Truncate(distance * precisionCoefficient) / precisionCoefficient;

                return truncatedDistance;
            }
        }

        private static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            var points = new Point[length];
            for (int i = 0; i < length; i++)
            {
                var input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                points[i] = new Point(x: input[0], y: input[1]);
            }

            var minimumDistance = CalculateClosestDistance(points);
            Console.WriteLine(minimumDistance);
        }

        private static decimal CalculateDistance(Point[] points, decimal minimum = Int32.MaxValue)
        {
            for (int i = 0; i < points.Length; ++i)
            {
                for (int j = i + 1; j < points.Length && Math.Abs(points[j].YCoordinate - points[i].YCoordinate) < minimum; ++j)
                {
                    var distance = Point.CalculateDistance(points[i], points[j]);
                    minimum = Math.Min(distance, minimum);
                }
            }

            return minimum;
        }

        private static decimal CalculateClosestDistanceRecursive(Point[] points)
        {
            if (points.Length <= 3)
            {
                return CalculateDistance(points);
            }

            var middle = points.Length / 2;

            var leftSegmentPoints = new List<Point>();
            for (int i = 0; i < middle; i++)
            {
                leftSegmentPoints.Add(points[i]);
            }
            var rightSegmentPoints = new List<Point>();
            for (int i = middle; i < points.Length; i++)
            {
                rightSegmentPoints.Add(points[i]);
            }

            decimal leftSegmentMinimum = CalculateClosestDistanceRecursive(leftSegmentPoints.ToArray());
            decimal rightSegmentMinimum = CalculateClosestDistanceRecursive(rightSegmentPoints.ToArray());
            decimal minimum = Math.Min(leftSegmentMinimum, rightSegmentMinimum);
            var candidates = new List<Point>();
            var middlePoint = points[middle];

            foreach (var point in points)
            {
                if (Math.Abs(middlePoint.XCoordinate - point.XCoordinate) < minimum)
                {
                    candidates.Add(point);
                }
            }

            var pointSortedByY = candidates.OrderBy(p => p.YCoordinate).ToArray();

            return Math.Min(minimum, CalculateDistance(pointSortedByY, minimum));
        }

        public static decimal CalculateClosestDistance(Point[] points)
        {
            var pointSortedByX = points.OrderBy(p => p.XCoordinate).ToArray();

            return CalculateClosestDistanceRecursive(pointSortedByX);
        }
    }
}