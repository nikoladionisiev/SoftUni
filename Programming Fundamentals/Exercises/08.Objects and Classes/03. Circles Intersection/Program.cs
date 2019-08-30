using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircle = Console.ReadLine().Split().Select(int.Parse).ToArray();


            Circle circle1 = new Circle();
            circle1.Center = new Point() {X = firstCircle[0], Y = firstCircle[1] };
            circle1.Radius = firstCircle[2];



            Circle circle2 = new Circle();
            circle2.Center = new Point() { X = secondCircle[0], Y = secondCircle[1] };
            circle2.Radius = secondCircle[2];



            if (Intersect(circle1, circle2))
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }

        }

        static bool Intersect(Circle c1, Circle c2)
        {
            double distanceX;
            double distanceY;

            if (c1.Center.X > c2.Center.X)
            {
                distanceX = c1.Center.X - c2.Center.X;

            }
            else
            {
                distanceX = c2.Center.X - c1.Center.X;
            }

            if (c1.Center.Y > c2.Center.Y)
            {
                distanceY = c1.Center.Y - c2.Center.Y;

            }
            else
            {
                distanceY = c2.Center.Y - c1.Center.Y;
            }

            double distance = Math.Pow(distanceX ,2) + Math.Pow(distanceY,2);
            distance = Math.Sqrt(distance);

            if (distance <= c1.Radius + c2.Radius)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
