using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Rectangle_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rectanglesCount = n[0];
            int intersectionCount = n[1];

            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < rectanglesCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                //id, width, height and coordinates
                string name = input[0];
                double width = double.Parse(input[1]);
                double height = double.Parse(input[2]);
                double x = double.Parse(input[3]);
                double y = double.Parse(input[4]);

                Rectangle rectangle = new Rectangle(name, width, height, x, y);
                rectangles.Add(rectangle);

            }

            for (int i = 0; i < rectanglesCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string firstId = input[0];
                string secondId = input[1];

                Rectangle firstRectangle = rectangles.FirstOrDefault(x => x.Id == firstId);
                Rectangle secondRectangle = rectangles.FirstOrDefault(x => x.Id == secondId);

                if (firstRectangle.Intersect(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }


        }
    }
}
