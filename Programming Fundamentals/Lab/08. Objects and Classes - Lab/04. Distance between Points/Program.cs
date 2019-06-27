using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] firstPoint = Console.ReadLine().Split().ToArray();
            string [] secondPoint = Console.ReadLine().Split().ToArray();


            var pointX = new Point { X = int.Parse(firstPoint[0]), Y = int.Parse(firstPoint[1]) };
            var pointY = new Point { X = int.Parse(secondPoint[0]), Y = int.Parse(secondPoint[1]) };


            var result = Distance(pointX, pointY);
            Console.WriteLine(result);
        }   

        static double Distance (Point first, Point second)
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
