using System;
using System.Collections.Generic;

namespace _05._Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            var allPoints = new List<Point>();   

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();

                allPoints.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstMinPoint = null;
            Point secondMinPoint = null;


            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    var firstPoint = allPoints[i];
                    var secondPoint = allPoints[j];

                    var currentDisctance = Distance(firstPoint, secondPoint);

                    if (currentDisctance < minDistance)
                    {
                        minDistance = currentDisctance;
                        firstMinPoint = firstPoint;
                        secondMinPoint = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance :F3}");
            Console.WriteLine($"{firstMinPoint.X}, {firstMinPoint.Y}");
            Console.WriteLine($"{secondMinPoint.X}, {secondMinPoint.Y}");
        }

         static Point ReadPoint()
        {
            var pointData = Console.ReadLine().Split(' ');

            var point = new Point
            {
                X = int.Parse(pointData[0]),
                Y = int.Parse(pointData[1])
            };
            return point;
        }

        static double Distance(Point first, Point second)
        {
            var x = first.X - second.X;
            var xPow = x * x;

            var y = first.Y - second.Y;
            var yPow = y * y;

            return Math.Sqrt(xPow + yPow);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
